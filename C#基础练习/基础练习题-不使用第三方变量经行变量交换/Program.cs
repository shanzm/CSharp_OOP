using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_不使用第三方变量经行变量交换
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =1;
            int b = 2;
            a = a ^ b;//异或运算
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("a={0},b={1}", a, b);
            Console.ReadKey();


        }
    }
}
