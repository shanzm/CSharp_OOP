using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_集合_合并集合排除重复
{
    class Program
    {
        /// <summary>
        /// 合并两个集合，排除重合的元素
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() { "a", "b", "c", "d", "e" };
            List<string> list2 = new List<string>() { "c", "d", "e", "f", "g", "h" };

            foreach (string item in list2 )
            {
                //if (list1.Contains(item))
                //{
                //    continue;
                //}
                //else
                //{
                //    list1.Add(item);
                //}

                //只需一个if
                if (!list1 .Contains(item ))
                {
                    list1.Add(item);
                }
            }

            foreach (string  item in list1 )
            {
                Console.Write(item);
            }
            Console.ReadKey();

        }
    }
}
