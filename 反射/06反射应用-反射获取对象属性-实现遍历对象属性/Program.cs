using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace _06反射应用_反射获取对象属性_实现遍历对象属性
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //首先：我们为什么要将一个实例对象转为Hashtable
            //有时候我们需要在内存中操作数据，对某个对象的属性进行遍历，这时候就需要反射对象属性进行遍历
            //多次需要这样的操作，则我们可以封装一个方法——将对象转为Hashtable，这样遍历Hashtable就方便了

            Student student = new Student() { Name = "张三", ChineseScore = 100, EnglishScore = 100, MathScore = 100, PEScore = 100 };
            Hashtable hsStudent = HashTableHelper.Object2Hashtable(student);

            //遍历Hashtable找到指定的字段
            //ForeachHashtable(hsStudent);

            //遍历Hashtable并修改
            //UpdateHashtable(hsStudent);

            //将对象集合转为Datatable
            //TestToDataTable();

            //将Datatable转为对象集合
            TestToList();
            Console.ReadKey();
        }

        private static void ForeachHashtable(Hashtable hsStudent)
        {
            foreach (DictionaryEntry keyValue in hsStudent)//遍历方法1
            {
                if (keyValue.Key.ToString().Contains("Score"))
                {
                    Console.WriteLine(keyValue.Value);
                }
            }

            foreach (string key in hsStudent.Keys)//遍历方法2
            {
                if (key.Contains("Score"))
                {
                    Console.WriteLine(hsStudent[key]);
                }
            }
        }

        private static void UpdateHashtable(Hashtable hsStudent)
        {
            //foreach (string key in hsStudent.Keys)//错误方法：报错：集合已修改，可能无法执行枚举操作
            //{
            //    if (key.Contains("Score"))
            //    {
            //        hsStudent[key] = (int)hsStudent[key] - 10;
            //    }
            //}

            //上面遍历的时候需要修改HashTable中的键值，一般会报异常，提示您的集合已修改，因为foreach遍历的时候，in 后面的集合不可更改
            //现将现有的Hashtable克隆一个，
            //遍历原有的Hashtable，
            //循环变量使用的是原Hashtable的key，
            //操作Clone的Hashtable中的value,最终克隆后的Hashtable就是我们期望的值
            Hashtable hsStudentCopy = (Hashtable)hsStudent.Clone();

            foreach (string key in hsStudent.Keys)
            {
                if (key.Contains("Score"))
                {
                    hsStudentCopy[key] = (int)hsStudentCopy[key] - 10;
                }
            }
            //hsStudentCopy就是我们期望的结果
            Student student = HashTableHelper.Hashtable2Object<Student>(hsStudentCopy);
            Console.WriteLine(student.ChineseScore);

        }

        private static void TestToDataTable()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Name = "张三", ChineseScore = 100, EnglishScore = 100, MathScore = 100, PEScore = 100 },
                new Student() { Name = "张三" },
            };
            DataTable dt = ConvertHelper.ToDataTable(students);
        }


        private static void TestToList()
        {
            DataTable dtStudent = new DataTable("Student");
            dtStudent.Columns.Add("Name", Type.GetType("System.String"));
            dtStudent.Columns.Add("ChineseScore", Type.GetType("System.Int32"));
            dtStudent.Rows.Add(new object[] { "张三", 100 });
            dtStudent.Rows.Add(new object[] { "李四", 200 });

            List<Student> students = ConvertHelper.ConvertToModel<Student>(dtStudent).ToList();
        }

        class Student
        {
            public string Name { get; set; }
            public int ChineseScore { get; set; }
            public int EnglishScore { get; set; }
            public int MathScore { get; set; }
            public int PEScore { get; set; }
        }



        /// <summary>
        /// Hashtable和T对象互相转换辅助类
        /// </summary>
        public static class HashTableHelper
        {
            /// <summary>
            /// C# Hashtable转object实体对象
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="source"></param>
            /// <returns></returns>
            public static T Hashtable2Object<T>(Hashtable source)
            {
                T obj = Activator.CreateInstance<T>();
                object tv;

                PropertyInfo[] ps = obj.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                foreach (PropertyInfo p in ps)
                {
                    if (source.ContainsKey(p.Name))
                    {
                        tv = source[p.Name];

                        if (p.PropertyType.IsArray)//数组类型,单独处理
                        {
                            p.SetValue(obj, tv, null);
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(tv.ToString()))//空值
                            {
                                tv = p.PropertyType.IsValueType ? Activator.CreateInstance(p.PropertyType) : null;//值类型
                            }
                            else
                            {
                                tv = System.ComponentModel.TypeDescriptor.GetConverter(p.PropertyType).ConvertFromString(tv.ToString());//创建对象
                            }

                            p.SetValue(obj, tv, null);
                        }
                    }
                }

                return obj;
            }

            /// <summary>
            /// C# 实体对象Object转HashTable
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="obj"></param>
            /// <returns></returns>
            public static Hashtable Object2Hashtable(object obj)
            {
                Hashtable hash = new Hashtable();

                PropertyInfo[] ps = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo p in ps)
                {
                    hash.Add(p.Name, p.GetValue(obj));
                }
                return hash;
            }
        }



        /// <summary>
        /// Datatable与泛型集合互相转换辅助类
        /// 参考：https://www.cnblogs.com/shiyh/p/7478241.html
        /// </summary>
        public static class ConvertHelper
        {

            /// <summary>
            /// IEnumerable泛型对象集合转为Datatable
            /// </summary>
            /// <typeparam name="T">泛型</typeparam>
            /// <param name="collection"></param>
            /// <returns></returns>
            public static DataTable ToDataTable<T>(IEnumerable<T> collection)
            {
                PropertyInfo[] props = typeof(T).GetProperties();
                DataTable dt = new DataTable(typeof(T).Name);
                dt.Columns.AddRange(props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray());
                if (collection.Count() > 0)
                {
                    for (int i = 0; i < collection.Count(); i++)
                    {
                        ArrayList tempList = new ArrayList();
                        foreach (PropertyInfo pi in props)
                        {
                            object obj = pi.GetValue(collection.ElementAt(i), null);
                            tempList.Add(obj);
                        }
                        object[] array = tempList.ToArray();
                        dt.LoadDataRow(array, true);
                    }
                }
                return dt;
            }


            /// <summary>
            /// 将Datatable转换为对象集合
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="dt"></param>
            /// <returns></returns>
            public static IList<T> ConvertToModel<T>(DataTable dt) where T : new()
            {
                // 定义集合    
                IList<T> ts = new List<T>();

                // 获得此模型的类型   
                Type type = typeof(T);
                string tempName = "";

                foreach (DataRow dr in dt.Rows)
                {
                    T t = new T();
                    // 获得此模型的公共属性      
                    PropertyInfo[] propertys = t.GetType().GetProperties();
                    foreach (PropertyInfo pi in propertys)
                    {
                        tempName = pi.Name;  // 检查DataTable是否包含此列    

                        if (dt.Columns.Contains(tempName))
                        {
                            // 判断此属性是否有Setter      
                            if (!pi.CanWrite)
                            {
                                continue;
                            }

                            object value = dr[tempName];
                            if (value != DBNull.Value)
                            {
                                pi.SetValue(t, value, null);
                            }
                        }
                    }
                    ts.Add(t);
                }
                return ts;
            }
        }
    }
}