using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_键值对_每个字符出现的次数
{
    class Program
    {
        static void Main(string[] args)
        {

            string strs = "aa bbbb ccccc dd";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char  item in strs )
            {
                if (item==' ')
                {
                    continue ;
                }
                else if (dic.ContainsKey (item))
                {
                    dic[item]++;
                }
                else if (!dic.ContainsKey (item))
                {
                    dic[item] = 1;
                }
            }

            foreach (KeyValuePair <char,int> item in dic )
            {
                Console.WriteLine("{0}----{1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}
