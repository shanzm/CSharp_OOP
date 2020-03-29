using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//利用IEnumerable<T> 实现斐波那契数列生成
//斐波拉数列：从第3项开始，每一项都等于前两项之和
//1、1、2、3、5、8、13、21、34……
namespace 面试题_斐波拉序列
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> result = GenerateFib2(8);
            Array.ForEach(result.ToArray(), t => Console.WriteLine(t));

            Console.ReadKey();
        }



        private static IEnumerable<int> GenerateFib1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                yield return fibRec(i);
            }
        }

        //递归方式实现：f(n) = f(n - 1) + f(n - 2)
        public static int fibRec(int num)
        {
            if (num < 1) return 0;

            if (num < 3) return 1;

            return fibRec(num - 1) + fibRec(num - 2);
        }

        private static IEnumerable<int> GenerateFib2(int n)
        {
            if (n >= 1) yield return 1;

            int a = 1, b = 0;
            for (int i = 2; i <= n; ++i)
            {
                int t = b;
                b = a;
                a += t;

                yield return a;
            }
        }

    }
}
