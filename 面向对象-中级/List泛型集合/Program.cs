using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 4, 5, 6, 7, 8 });
            list.AddRange(list);
            //
           //泛型集合既可以使用for也可以使用foreach遍历
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //////////////////////////////////////////泛型的一些方法和集合的方法都是一样的
            //插入
            list.Insert(0, 1000);
            list.InsertRange(1, new int[] { 100, 10 });

            //移除
            list.Remove(1000);
            list.RemoveAt(0);
            list.RemoveRange(0, 1);

            //翻转
            list.Reverse();

            //求和
            int sum = list.Sum();
            Console.WriteLine(sum);

            //顺序排序
            list.Sort();

            //泛型集合转换为数组,f返回的数组的类型是根据你泛型集合中存储数据的类型所确定的
            int[] myArray=list.ToArray ();
            //比如说，当你的泛型是字符串类型的时候，返回的数组就是字符串类型的数组
            List<string> stringList = new List<string>();
            string[] myStringArray = stringList.ToArray();


            //当然，数组也是可以转换为集合的
            char[] charArray = new char[] { 'a', 's', 'd', 'f' };
            List<char> charList=charArray.ToList();
            foreach (char  item in charList)
            {
                Console.WriteLine(item);
            }

            
          
            Console.ReadKey();

        }
    }
}
