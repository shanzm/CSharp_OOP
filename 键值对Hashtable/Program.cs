using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace 键值对集合Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hs = new Hashtable();
            hs.Add(1, "a");
            hs.Add (2,"b");
            hs.Add(3, true);
            hs.Add(false, "c");

            ///赋值的其他方法
            hs[4] = "d";
            hs[4] = "e";//将之前的重新赋值

            Console.WriteLine(hs[1]);
            Console.WriteLine(hs[false]);
            Console.WriteLine(hs[4]);

            if (hs.ContainsKey(1))
            {
                hs[1] = "替换";
            }


            ///注意无法使用for循环来遍历键值对
            ///我们使用foreach
            //foreach (var item in hs.Values)//hs.Values为值
            //{
            //    Console .WriteLine (item);
            //}


            //hs.Keys为键
            foreach (var item in hs.Keys )
            {
                Console.WriteLine(hs[item]);
            }

        
            Console.ReadKey();


        }
    }
}
