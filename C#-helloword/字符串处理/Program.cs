using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aa,bb,cc,,qq";//第四个是长度为0 的字符串
            //*test1*/string[] strs = str.Split(',');
            //*test2*/string[] strs=str.Split (new char[1]{','},StringSplitOptions .RemoveEmptyEntries);
            /*其中new char[]{','}，就是新定义一个字符类型的数组，这样看你就明白了
            char[] chars=new char[1]{','},
             即换言之，此句可以写为:*/

            char[] chars = new char[1] { ',' };
            string[] strs = str.Split(chars, StringSplitOptions.
                RemoveEmptyEntries);
            foreach (string val in strs)
            {
                Console.WriteLine(val);
            }
            Console.ReadKey();

        }
    }
}
