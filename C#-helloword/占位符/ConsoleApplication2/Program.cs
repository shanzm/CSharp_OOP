using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            Console.WriteLine("input your name ");
            username = Console.ReadLine();
            Console.WriteLine("welcome {0}!",username);
            //c#6.0(vs2015)中占位符的使用有变化，不需要使用{0}，{1}，{2}...来占位
            //而是直接将要赋值的变量放在{}中，但在整个输出语句前要加上$
            //比如说，此处在vs2015中（c#6.0)可以写为
            //Consol.WriteLine($"welcome{username}");
            Console.ReadKey();
        }
    }
}
