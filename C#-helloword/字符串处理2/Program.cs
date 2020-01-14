using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 字符串处理2
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入一个邮箱地址，将该邮箱的地址分为域名和用户名，分别打印出来
            Console.WriteLine("please enter your e-mail:");
            string email = Console.ReadLine();
            int atIndex = email.IndexOf('@');//找到@的位置
            string uesrname = email.Substring(0, atIndex);//从0位置开始取字串，长度为atIndex
            string 域名 = email.Substring(atIndex + 1);//从atIndex +1开始取字串，长度为直达末尾
            Console.WriteLine("用户名:{0}\n域名:{1}", uesrname, 域名);
            Console.ReadKey();
        }
    }
}
