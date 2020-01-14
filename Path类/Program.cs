using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = @"E:\c#\新-传智c#系列\szm.avi";
            //最原始的对字符串处理的方法——获取文件名
            int index=str.LastIndexOf ('\\');
            string  strName=str.Substring (index+1);
            Console.WriteLine (strName);

            //获取文件名
            Console.WriteLine(Path.GetFileName(str));
            //获取文件名，不带后缀名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获取文件后缀名
            Console.WriteLine(Path.GetExtension(str));
            //获取文件的路径名
            Console.WriteLine(Path.GetDirectoryName(str));
            //链接两个字符串作为路径
            Console .WriteLine(Path.Combine (@"c:\aa\","1.txt"));

            Console.ReadKey();
        }
    }
}
