using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_键值对_阿拉伯数字替换
{
    class Program
    {

        /// <summary>
        /// 给你一个字符串str="1一 2二 3三 4四 5五 6六 7七 8八 9 九"
        /// 当用户输入一句话，如果包含阿拉伯数字，则替换
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string str = "1一 2二 3三 4四 5五 6六 7七 8八 9九";
            string[] strs = str.Split(" "[0]);
            //Split(" "[0]);注意此处我故意这么字写得，
            //只为了强调字符串是char类型的只读数组
            //所以字符串中的字符可以使用下表索取" "[0]就是' ' 
            Dictionary<char, char> dic = new Dictionary<char, char>();

            //foreach (string item in strs)
            //{
            //    dic.Add(item[0], item[1]);
            //}
            for (int i = 0; i < strs.Length; i++)
            {
                dic.Add(strs[i][0], strs[i][1]);
            }

            //使用foreach循环省略了写数组的下表，这时看上去就比较明了

            Console.WriteLine("enter a string（include some numbers）");
            string strs2 = Console.ReadLine();
            //foreach (char  item in strs2 )
            //{
            //    if (dic.ContainsKey (item))
            //    {
            //        Console.Write(dic[item]);
            //    }
            //    else
            //    {
            //        Console.Write(item);
            //    }
            //}
            for (int i = 0; i < strs2.Length; i++)
            {
                if (dic.ContainsKey(strs2[i]))
                {
                    Console.Write(dic[strs2[i]]);
                }
                else
                {
                    Console.Write(strs2[i]);
                }
            }
            Console.ReadKey();

        }
    }
}
