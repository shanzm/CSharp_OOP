using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串的使用4
{
    class Program
    {
        static void Main(string[] args)
        {


            /////////////////////////////////////////////////////////法一
            
            //打印一个字符串之后，找到其中某个字母出现的次数和位置
            string str = "fffffefefffffffefffffffffeffe";
            int index = str.IndexOf("ef");
            Console.WriteLine(index);
            int count = 1;
            while (index != -1)
            {
                count++;

                index = str.IndexOf("ef", index + 1);//当IndexOf的第二个参数，起始顺序index+1超过了字符串的长度时，就返回”未找到该字符“，即显示出来就是”-1“
                //没有这个判断，当循环到寻找第六个e是2，返回为-1，就会打印出来”第-1个位置出现第6个e"
                if (index == -1)
                {
                    break;
                }
                
                Console.WriteLine("第{0}个位置出现第{1}个”ef“", index, count);
            }
            Console.ReadKey();
            
            
            

            ////////////////////////////////////////////////////法二
            
            /*
            string str = "fffffefefffffffefffffffffeffe";
            char[] chas = str.ToCharArray();
            int count=0;
            for (int i = 0; i <= str.Length - 1; i++)
            {

                
                if (chas[i] == 'e')
                {
                    count++;
                    Console.WriteLine("第{0}个位置出现第{1}个e", i + 1, count);

                }
            }
            Console .ReadKey ();
            */
            //////////////////////////////////////////////////////法三
            //string str = "fffffefefffffffefffffffffeffe";
            //for (int i = 0; i <= str.Length - 1; i++)
            //{
            //    if (str[i]=='e')
            //    {
            //        Console.WriteLine (）;
            //    }
            //    Console.ReadKey ();
            //}
        }
    }
}
