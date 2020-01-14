using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_字符串中字符出现的次数及位置
{
    class Program
    {
        static void Main(string[] args)
        {
            ////法1
            //string str = "fffffefefffffffefffffffffeffe";

            //int index = str.IndexOf("e");

            //int count = 1;

            //while (index !=-1)
            //{
               
            //    index = str.IndexOf("e",index+1);
                

            //    //没有这个判断，当循环到寻找第六个e是2，返回为-1，就会打印出来”第-1个位置出现第6个e"
            //    if (index == -1)
            //    {
            //        break;
            //    }

            //    count++;
            //    Console .WriteLine ("第{0}个位置出现第{1}个e",index,count);
            //}
            //Console.WriteLine("总共{0}个e",count );


            ////法2
            string str = "fffffefefffffffefffffffffeffe";
            char[] chas = str.ToCharArray();
            int count = 0;
            for (int i = 0; i <= str.Length - 1; i++)
            {


                if (chas[i] == 'e')
                {
                    count++;
                    Console.WriteLine("第{0}个位置出现第{1}个e", i + 1, count);

                }
            }
            Console.ReadKey();
            


        }
    }
}
