using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string [] args)
        {
            //提示用户输入密码，如果密码是“88888”，则显示输入错误
            Console.WriteLine("please enter your password");
            string password= Console .ReadLine ();
            if (password =="8888")
            {
                Console .WriteLine("error!");
            }
            else 
                Console .WriteLine("intersting");
            Console.ReadKey();
        
        }
    }
}
