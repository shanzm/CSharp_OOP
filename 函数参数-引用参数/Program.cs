using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数参数_引用参数
{
    class Program
    {
        //引用参数
        //使用方式：使用引用参数时，必须在方法的声明和调用中都使用ref修饰符。
        //引用参数的实参必须是变量，在用作实参前必须被赋值。如果是引用类型变量，可以赋值为一个引用或nu11值。


        //引用参数使得实参名和形参名指向相同的内存位置，所以在函数执行中对形参做的改变，就是对实参做的改变
        //简单的说：引用参数使得值类型的参数像引用类型的参数一样，在函数执行后，在函数体外保留发生的改变

        static void Main(string[] args)
        {

            int num = 11;
            MyClass myClass = new MyClass();

            Do(ref num, myClass);

            Console.WriteLine($"a={num}");//a=22
            Console.WriteLine($"b={myClass.val }");//b=32

            Console.ReadKey();
        }

        static void Do(ref int num1, MyClass myClass)//这里的num1和myClass就是形参
        {
            num1 += 10;
            myClass.val += 10;
        }
    }
    class MyClass
    {
        public int val = 22;
    }
}

