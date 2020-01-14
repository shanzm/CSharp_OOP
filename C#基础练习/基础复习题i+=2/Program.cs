using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础复习题_自运算
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum();
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        /// <summary>
        /// 0到100奇书和
        /// </summary>
        /// <returns></returns>
        public static int Sum()
        {
            int sum = 0;
            //☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆☆注意i+=2
            for (int i = 1; i < 101; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
