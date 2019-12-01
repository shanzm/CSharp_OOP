using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数参数_值参
{
    class Program
    {
        //值参
        static void Main(string[] args)
        {
            //这里的num和myClass就是实参
            int num = 11;
            MyClass myClass = new MyClass();

            //num参数是值类型，所以实参num的值被复制给形参，最终函数执行后不影响实参num的值
            //muClass是引用类型，所以实参myClass的引用被复制给形参，所以函数执行后myClass发生改变。
            Do(num, myClass);

            Console.WriteLine($"a={num}");//a=11
            Console.WriteLine($"b={myClass.val }");//b=32
           
            
            Console.ReadKey();

        }

        //注意第一个参数是值类型的参数，第二个参数是引用类型的

        //注意区分：值类型和值参数无必然的联系，二者是不同的概念。值参概念相对的是实参概念。

        //注意这里做测试使用的引用类型是类，不要使用String类型，
        //因为字符串类型虽然是引用类型，但是因为“string的不变性”，
        //编译器会对齐做特殊处理，好像看上去使得string类型像是值类型
        //参见：https://blog.csdn.net/u011555996/article/details/79203220
        static void Do(int num1, MyClass myClass)//这里的num1和myClass就是形参
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
