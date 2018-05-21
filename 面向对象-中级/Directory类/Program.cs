using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Directory类
{
    class Program
    {
        static void Main(string[] args)
        {
            ////创建文件夹
            //Directory.CreateDirectory(@"C:\Users\shanzm\Desktop\新建文件夹");
            //Console.WriteLine("创建文件夹成功！");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"C:\Users\shanzm\Desktop\新建文件夹");
            //Console.WriteLine("删除文件夹成功！");
            //Console.ReadKey();

            ///若该文件夹中非空，即有其他文件，则加一个参数

            //Directory.Delete(@"C:\Users\shanzm\Desktop\新建文件夹",true );
            //Console.WriteLine("删除文件夹及问价中子文件成功");
            //Console.ReadKey();

            ////剪切
            //Directory.CreateDirectory(@"C:\Users\shanzm\Desktop\新建文件夹1");

            //Console.WriteLine("创建文件夹成功");
            //Console.ReadKey();
            //Directory.Move(@"C:\Users\shanzm\Desktop\新建文件夹1", @"C:\Users\shanzm\Desktop\新建文件夹2");
            //Console.WriteLine("剪切成功");
            //Console.ReadKey();

            ////获得指定文件夹内全部文件的全路径
            //string[] path=Directory.GetFiles (@"C:\Users\shanzm\Desktop");
            //foreach (string item in path)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            ///若是你想要获得指定文件夹内的全部同一种类型的文件的全路径，则加一个参数
            ///比如说获得全部的快捷方式型（lnk)文件的全路径
            //string[] path = Directory.GetFiles(@"C:\Users\shanzm\Desktop","*.lnk");
            //foreach (string item in path)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //获取指定文件夹内所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"C:\Users\shanzm\Desktop");
            //foreach (string item in path)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 

            //判断某文件夹中是否存在某文件夹
            if (!Directory.Exists(@"C:\Users\shanzm\Desktop\test"))
            {
                Directory.CreateDirectory(@"C:\Users\shanzm\Desktop\test");
                for (int i = 0; i <=100; i++)
                {
                    //在test文件夹中创建名为0~100的文件夹
                    Directory.CreateDirectory(@"C:\Users\shanzm\Desktop\test\" + i);
                }
            }
            Console.WriteLine("创建成功");
            Console.ReadKey();
        }
    }
}
