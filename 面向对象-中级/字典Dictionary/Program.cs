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
            Dictionary<int, string> myDictinary = new Dictionary<int, string>();
            myDictinary.Add(1, "a");
            myDictinary.Add(2, "b");
            myDictinary.Add(3, "c");
            //覆盖式赋值
            myDictinary[1] = "A";

            //foreach (KeyValuePair  <int ,string> item in myDictinary )
            //{
            //    Console.WriteLine("{0}:{1}",item.Key , item.Value);
            //}
            //法二
            foreach (int  item in myDictinary .Keys )
            {
                Console.WriteLine("{0}:{1}", item, myDictinary[item]);
               
            }
            Console.ReadKey();
        }
    }
}
