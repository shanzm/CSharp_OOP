using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_质数求和
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrimeSum ());
            Console.ReadKey();
        } 

        /// <summary>
        /// 0-100质数求和
        /// 质数定义为在大于1的自然数中，除了1和它本身以外不再有其他因数
        /// </summary>
        /// <returns></returns>
        public static int PrimeSum()
        {
            
            int sum = 0;
            for (int i = 2; i < 101; i++)// 1不是质数,故从2开始
            {
                bool b=true;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        b = false;
                        break;
                    }
                }

               

                if (b)
                {
                    sum += i;
                }
               
            }
            return sum;
        }
    }
}
