using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _04反射应用_反射获取对象属性
{
    class Program
    {
        static void Main(string[] args)
        {
            //我声明了一个apple实例，该实例转化为banana实例


            //依据原始类型创建一个目标类型对象
            Apple apple = new Apple() { Id = 1, Name = "苹果", Size = 10, Color = "red" };//原始对象
            Banana banana = RotationMapping<Banana, Apple>(apple);//目标对象
            Console.WriteLine(banana.Id + banana.Name + banana.Size);


            //依据原始类型对目标类型对象赋值
            Banana banana1 = new Banana() { Id = 2, Name = "蕉太郎", Size = 10 };//目标对象，使用原始对象apple的属性对banana1对象重新赋值
            RotationMapping<Banana, Apple>(banana1, apple);
            Console.WriteLine(banana1.Id + banana1.Name + banana1.Size);

            //依据原始类型对目标类型对象赋值
            Banana banana2 = new Banana() { Id = 3, Name = "焦二郎", Size = 10 };
            AutoMapping<Banana, Apple>(banana2, apple);
            Console.WriteLine(banana2.Id + banana2.Name + banana2.Size);
            Console.ReadKey();

        }


        #region 无继承关系对象的转换
        /// <summary>
        /// 依据S类型的实体创建一个T类型的实体
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <typeparam name="S">目标类型</typeparam>
        /// <param name="s">S类型实体</param>
        /// <returns>T类型实体</returns>
        public static T RotationMapping<T, S>(S s)
        {
            //使用泛型，反射获取指定类型的所有数据和目标类型的属性相匹配
            T target = Activator.CreateInstance<T>();//目标类型对象
            var originalObj = s.GetType();//原始类型
            var targetObj = typeof(T);
            foreach (PropertyInfo original in originalObj.GetProperties())
            {
                foreach (PropertyInfo t in targetObj.GetProperties())
                {
                    if (t.Name == original.Name)
                    {
                        t.SetValue(target, original.GetValue(s, null), null);
                    }
                }
            }
            return target;
        }




        /// <summary>
        /// 依据S类型的实体对一个T类型的实体的属性重新赋值
        /// </summary>
        /// <typeparam name="T">目标类型</typeparam>
        /// <typeparam name="S">原始类型</typeparam>
        /// <param name="t">目标类型对象</param>
        /// <param name="s">原始类型对象</param>
        static void RotationMapping<T, S>(T t, S s)
        {
            var originalObj = s.GetType();//原始类型
            var targetObj = typeof(T);//目标类型
            foreach (PropertyInfo sp in originalObj.GetProperties())
            {
                foreach (PropertyInfo dp in targetObj.GetProperties())
                {
                    if (dp.Name == sp.Name)
                    {
                        dp.SetValue(t, sp.GetValue(s, null), null);
                    }
                }
            }
        }



        /// <summary>
        /// 依据S类型的实体对一个T类型的实体的属性重新赋值
        /// </summary>
        /// <typeparam name="S">原始类型</typeparam>
        /// <typeparam name="T">目标类型</typeparam>
        /// <param name="s">原始类型对象</param>
        /// <param name="t">目标类型对象</param>
        static public void AutoMapping<T, S>(T t,S s )
        {
            PropertyInfo[] pps = GetPropertyInfos(s.GetType());
            Type target = t.GetType();

            foreach (var pp in pps)
            {
                PropertyInfo targetPP = target.GetProperty(pp.Name);
                object value = pp.GetValue(s, null);

                if (targetPP != null && value != null)
                {
                    targetPP.SetValue(t, value, null);
                }
            }

        }

        static public PropertyInfo[] GetPropertyInfos(Type type)
        {
            return type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }
        #endregion

    }

    #region 2021年7月22日 08:47:44-关于两个不相关（无继承关系的）的类相互转换
    //这两个类是Model类，类中只定义了一些属性
    //现在我又一个Apple对象，想要转换为Banana对象
    public class Apple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
    }

    public class Banana
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        //public string Color { get; set; }
    }
    #endregion
}




