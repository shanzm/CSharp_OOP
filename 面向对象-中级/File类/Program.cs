using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件
            //File.Create(@"C:\Users\shanzm\Desktop\test.txt");
            //Console.WriteLine("在桌面上创建了一个叫test.txt的文件");

            //删除一个文件
            //File.Delete(@"C:\Users\shanzm\Desktop\test.txt");
            //Console.WriteLine("删除了test.txt");

            //复制文件
            //File.Copy(@"C:\Users\shanzm\Desktop\1.txt", @"C:\Users\shanzm\Desktop\11.txt");
            ///注意，复制到新的文件11.txt，是系统新建的，不能该路径已经存在的
           


            ////读取文件之ReadAllByte
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\shanzm\Desktop\1.txt");
            //string s = Encoding.Default.GetString(buffer);
            //    ///注意Encoding后的属性有许多，即有许多种编码方式
            //    ///有UTF-8，GB2312，GBK，ASCII,Unicode
            //Console.WriteLine(s);
            
            ////写入文件内容WriteAllByte
            //string text = "我生待明日，万事成蹉跎";
            //byte[] buffer2 = Encoding.Default.GetBytes(text);
            //File.WriteAllBytes(@"C:\Users\shanzm\Desktop\1.txt", buffer2);
            /////注意此处若是指定的路径没有1.txt文件，则会自动创建一个1.txt文件，若是已经存在
            /////则会覆盖原有的1.txt文件
            //Console.WriteLine("写入成功");





            ////读取文件之ReadAllLine——她的返回值是一个字符串类型的数组
            //string[] text = File.ReadAllLines(@"C:\Users\shanzm\Desktop\1.txt", Encoding.Default );
            //foreach (string item in text )
            //{
            //    Console.WriteLine(item);
            //}

            //写入文件之WriteAllLine
            string[] text = { "长风破浪会有时，直挂云帆济沧海", "谁私任公子，云中骑碧驴" };
            File.WriteAllLines(@"C:\Users\shanzm\Desktop\1.txt", text);






            ////读取文件纸ReadAllText--他的返回值是一个字符串
            //string text1 = File.ReadAllText(@"C:\Users\shanzm\Desktop\1.txt", Encoding.UTF8);
            //Console.WriteLine(text1);

            ////写入文件之WriteAllText
            //string text2 = "零落成泥碾作尘，只有香如故";
            //File.WriteAllText(@"C:\Users\shanzm\Desktop\1.txt", text2);





            ///ReadAllByte适合所有类型文件，包括音频和视频等
            ///而ReadAllLine和ReadAllText只适合文本文件，其中ReadAllLine返回的是一个字符串类型
            ///的数组，ReadAllText返回的是一个字符串，因此你若是要对文本的每一行进行在处理
            ///你应该使用ReadAllLine方法
            

            ///注意WriteAll系类的写入方法都是覆盖式的写入，参数中文件路径有该文件则覆盖掉，没有则新建该文件

            //追加式写入——AddAll系列
            File .AppendAllLines (@"C:\Users\shanzm\Desktop\1.txt",text);




            Console.ReadKey();
        }
    }
}






