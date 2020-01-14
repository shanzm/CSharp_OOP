using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace 键值对集合Hashtable练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ///数字大小写转换

            const string Jian = "一二三四五六七八九十百千";
            const string fan = "壹贰叁肆伍陆柒捌玖拾佰仟";
            Hashtable conversion = new Hashtable();
            for (int i = 0; i < Jian.Length ; i++)
            {
                conversion.Add(Jian[i], fan[i]);

            }
            Console.WriteLine("Please enter a number in Chinese");
            string num = Console.ReadLine();
            for (int i = 0; i < num.Length ; i++)
            {
                if (conversion.ContainsKey(num[i]))
                {
                    Console.Write(conversion[(num[i])]);
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
