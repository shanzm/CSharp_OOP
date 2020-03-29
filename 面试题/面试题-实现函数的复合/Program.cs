using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//请实现一个函数Compose用于将多个函数复合


namespace 面试题_实现函数的复合
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int> Mul2 = x => x * 6;//f1
            Func<int, double> Div2 = x => x / 3;//f2
            Func<int, double> Recover = Mul2.Compose(Div2);//结果为：f2(f1),即Div2(Mul2(x))

            Console.WriteLine(Recover(10));//print:20
            Console.ReadKey();
        }
    }


    //给Func<T1,T2>定义一个Compose扩展方法
    public static class Extender
    {
        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T1, T2> f1, Func<T2, T3> f2) => x => f2(f1(x));
        //{
        //    return x => f2(f1(x));
        //}
    }
}
