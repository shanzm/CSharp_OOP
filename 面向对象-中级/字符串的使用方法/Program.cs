using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串的使用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.string 类型可以看做是char类型的只读数组；
            string str = "abcd";
            char[] chs = str.ToCharArray();
            chs[0] = 'A';
            str = new string(chs);
            Console.WriteLine("1.{0}", str);

            //2.字符串的比较
            string str2 = "ABCD";
            if (str.Equals(str2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("2.true");
            }
            else
            {
                Console.WriteLine("2.false");
            }

            //3.字符串分隔

            string str3 = "a   b,,,,,c++==ef";

            //char [] chs1=new char[] { ' ', '+', '=', ',' };


            //注意返回的是一个string类型的数组，虽然我们明知道每一个元素都是一个字母，好像是char[]类型的数组
            string[] str4 = str3.Split(new char[] { ' ', '+', '=', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("3.{0},{1},{2}", str4[0], str4[1], str4[2]);


            //4.判断字符串是否为空
            string str5 = "   ";//注意空格不是空，null是空或是""为空
            if (string.IsNullOrEmpty(str5))///注意调用格式，是使用string调用
            {
                Console.WriteLine("4.字符串为空");
            }
            else
            {
                Console.WriteLine("4.字符串不是空");
            }


            //5.序号函数IndexOf
            string str6 = "我是单志铭。单志铭不是好人";
            int a = str6.IndexOf('单');
            int b = str6.LastIndexOf('单');
            Console.WriteLine("5." + str6);
            Console.WriteLine("第一个单出现的位置:{0}", a + 1);
            Console.WriteLine("最后一个出现的单的位置:{0}", b + 1);


            //7.取子字符串Substring

            string str7 = @"htttp://wwww.baidu.com/单志铭qqq/单志铭wwww/单志铭单.avi";
            int a7 = str7.LastIndexOf('/');///注意我们找的是最后一个"/"，而不是最后一个”单“
            string substr7 = str7.Substring(a7 + 1);
            Console.WriteLine("7." + substr7);//截取文件————单志铭单.avi文件名

            //8.去除字符创中的空格
            string str8 = "             szm             ";
            Console.WriteLine("8.\n" + str8);
            string str8_1 = str8.Trim();
            Console.WriteLine(str8_1);
            string str8_2 = str8.TrimStart();
            Console.WriteLine(str8_2);
            string str8_3 = str8.TrimEnd();
            Console.WriteLine(str8_3 + "1");

            //9.字符创的添加符号链接Jion
            string[] str9s = { "张三", "李四", "王五", "周六" };
            string str9 = string.Join("和", str9s);
            Console.WriteLine("9." + str9);

            //10.判读是否以某个字符创结尾/开始
            bool bools1 = str9.EndsWith("张三");
            bool bools2 = str9.StartsWith("张三");
            Console.WriteLine("10." + bools1 + bools2);

            //11包含contains和替换replace
            string str11 = "单志铭是一个坏蛋！";
            if (str11.Contains("单志铭"))
            {
                str11 = str11.Replace("单志铭", "和谐");
                Console.WriteLine(str11);
            }
            Console.ReadKey();

            




            Console.ReadKey();


        }
    }
}
