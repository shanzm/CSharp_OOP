using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字典Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //新建一个字典类型并初始化
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            //myDictinary.Add(1, "a");
            //myDictinary.Add(2, "b");
            //myDictinary.Add(3, "c");

            //2019年12月1日 21:52:01
            //使用快速初始化器
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            //{
            //    { 1,"a"},
            //    {2,"b" },
            //    {3,"c" }
            //};

            //2019年12月1日 21:54:47
            //C#6.0
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                [1] = "a",
                [2] = "b",
                [3] = "c"
            };



            //覆盖式赋值
            myDictionary[1] = "A";

            //foreach (KeyValuePair  <int ,string> item in myDictinary )
            //{
            //    Console.WriteLine("{0}:{1}",item.Key , item.Value);
            //}
            //法二
            foreach (int item in myDictionary.Keys)
            {
                Console.WriteLine("{0}:{1}", item, myDictionary[item]);

            }
            Console.ReadKey();
        }
    }
}
