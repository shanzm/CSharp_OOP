using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数参数_输出参数
{
    class Program
    {
        //输出参数
        //使用方法：在方法的声明和调用中都使用ref修饰符对参数进行修饰
        //输出参数的实参必须是已经声明变量（因为方法需要内存位置保存输出参数的返回值），但是不要求对其赋值

        //在方法内部，输出参数在被读取之前必须被赋值。
        //这意味着参数的初始值是无关的，而且没有必要在方法调用之前为实参赋值。

        //在方法返回之前，方法内部的任何贯穿的可能路径都必须为所有输出参数进行一次赋值。

        //功能和引用参数是一样的，方法内对形参做的任何改变同样作用在实参上。

        //注意换一个角度说：函数的返回值一般就只有一个，但是使用一个输出参数就相当于是给函数添加一个返回值
        static void Main(string[] args)
        {

            int num = 11;//在方法内部，输出参数在被读取之前必须被赋值。
                         //这意味着参数的初始值是无关的，而且没有必要在方法调用之前为实参赋值。
                         //所以你在这里给输出参数num赋值11也没啥意义
            int num2;
            Do(out num, out num2);

            Console.WriteLine($"a={num}");//a=10
            Console.WriteLine($"b={num2}");//b=10

            Console.ReadKey();
        }

        static void Do(out int num1, out int num2)//这里的num1和myClass就是形参
        {
            num1 = 1;//在方法内部，输出参数在被读取之前必须被赋值
            num1 += 9;
            num2 = 2;
            num2 *= 5;
        }
    }

}

