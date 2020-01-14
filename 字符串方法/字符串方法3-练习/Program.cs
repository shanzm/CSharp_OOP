using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace 字符串的使用3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("1.txt");
            foreach (string item in lines)
            {
                string[] strs = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = strs[0];
                string auther = strs[1];
                
                //if (title.Length >= 17)
                //{
                //    title = title.Substring(0, 17);
                //    title = title + "...";
                //}
                //使用三元运算代替if
                Console.WriteLine("文章名：{0}\n,作者名：{1}\n", title.Length < 17 ? title : title.Substring(0, 17) + "...", auther);

            }
            Console.ReadKey();
        }
    }
}
