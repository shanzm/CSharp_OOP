using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串处理3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*读取文件d盘中txt文件，该文件中为文章标题和作者，其中标题和作者以空格
            分隔，其中空格各行并一定相同。每一行为一个标题和一个作者。当文章标题长度大于17时
             我们只保留前17个字符，后面的用三个点来表示
             */


             string[] lines = System.IO.File.ReadAllLines(@"d:\1.txt", Encoding.Default);
             foreach (string item in lines)
            {
              string[] strs = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                        
                        //虽然不确定文章名和作者名之间空了多少空格，但是一定是有空格的，所以以空格来
                //分裂字符串，同时设置split的另外一个参数，去掉空格


                string title = strs[0];
                string author = strs[1];
                if(title.Length >= 17)
                {
                    title = title.Substring(0, 17);
                    title = title + "...";
                }
                 Console.WriteLine("文章名：{0}\n 作者:{1}\n", title, author);
                
            }
            Console.ReadKey();
        }
    }
}
