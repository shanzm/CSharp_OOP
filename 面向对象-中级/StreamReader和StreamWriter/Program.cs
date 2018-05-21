using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;


namespace StreamReader和StreamWriter
{
    /// <summary>
    /// StreamReader和StreamWriter这两个类和FileStream不同之处就在于
    /// StreamReader和StreamWriter是处理字符的，而FileStream是处理字节的
    /// 注意FileStream相比来说更重要，因为他可以处理各种文件，而且可以处理大文件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ///采用StreamReader读取文件内容
            //using (StreamReader sr = new StreamReader(@"C:\Users\shanzm\Desktop\1.txt", Encoding.Default))
            /////注意注意-using（）这句代码最后的是两个括号啊
            //{
            //    while (!sr.EndOfStream)//注意此处的判断语句EndOfSrtream是指流的末尾，为布尔类型，前面又加上一个！，表示没到流的末尾
            //    {
            //        Console.WriteLine(sr.ReadLine());

            //    }


            //}

            ///采用StreamWriter写入文件
            using (StreamWriter sw=new StreamWriter (@"C:\Users\shanzm\Desktop\1.txt" ,true ))
            //若该路径已经存在该文件，则会将文件的内容覆盖掉，没有文件则新建一个文件
            //若是不覆盖，而是在文件内容后面添加，则要添加一个参数true(见重载函数第4个）
            {
                string contain="    将进酒";
                sw.WriteLine(contain);

            }

            Console.WriteLine("写入成功");
            Console.ReadKey();
        }
    }
}
