using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符创的使用方法2
{
    class Program
    {
        static void Main(string[] args)
        {

            //倒序输出一个字符串
            string str = "hello word !";
            string[] strs = str.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries );
            
            for(int i=0;i<=(strs.Length-1)/2;i++)
            {
                string temp=strs[i];
                strs[i]=strs[strs.Length -1-i];
                strs[strs.Length -1-i]=temp;
            }

            foreach (string str1 in strs )
            {
                Console.Write(str1+" "  );
            }
            Console .ReadKey ();
        }
    }
}
