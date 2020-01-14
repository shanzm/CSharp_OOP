using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //一般switch语句都是用来判断离散的情况
            int i = 2;
            switch (i)
            {
                case 1: Console.WriteLine("error");
                    break;
                case 2: Console.WriteLine("true");
                    break;
                default: Console.WriteLine("no mean ");
                    break;
            }
        }
    }
}
