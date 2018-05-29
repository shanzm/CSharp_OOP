using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串方法5_句中每个单词字母反序
{
    class Program
    {
        /// <summary>
        /// "I Love You !"变成"I evoL uoY !"
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string str = "I Love You !";
            string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string s = null;
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = Reverse(strs[i]);
                s += strs[i]+" ";
            }

            Console.WriteLine(s);
            Console.ReadKey();

        }


        /// <summary>
        /// 对单词反序
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Reverse(string str)
        {

            char[] chas = str.ToCharArray();
            //for (int i = 0; i < chas.Length / 2; i++)
            //{
            //    char temp = chas[i];
            //    chas[i] = chas[chas.Length - i - 1];
            //    chas[chas.Length - i - 1] = temp;
            //}
            Array.Reverse(chas);//这是.Net的自带方法

            return new string(chas);
        }


    }
}
