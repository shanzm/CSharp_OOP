using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_质数判断
{
    class Program
    {
        static void Main(string[] args)
        {
           // string b = Judge(5).ToString();
            bool b = LsPrime(5);
            Console.WriteLine(b);//可以直接打印布尔类型变量
            Console.ReadKey();
        }



        /// <summary>
        /// 定义:约数只有1和本身的整数称为质数,或称素数
        /// 判断质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool LsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
