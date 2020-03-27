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
            bool b = IsPrime3(5);
            Console.WriteLine(b);

            
            Console.ReadKey();
        }



        /// <summary>
        /// 定义:约数只有1和本身的整数称为质数,或称素数
        /// 判断质数
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime1(int n)
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

        //改进1：
        //一个数若可以进行因数分解，那么分解时得到的两个数一定是一个小于等于sqrt(n)，一个大于等于sqrt(n)，
        //据此，上述代码中并不需要遍历到n-1，遍历到sqrt(n)即可，因为若sqrt(n)左侧找不到约数，那么右侧也一定找不到约数
        public static bool IsPrime2(int n)
        {
            int temp = Convert.ToInt16((Math.Sqrt(n)));

            for (int i = 2; i <= temp; i++)//注意这里是“<=”
            {
                if (temp % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPrime3(int n)
        {
            if (n % 2 == 0)
                return n == 2;
            if (n % 3 == 0)
                return n == 3;
            if (n % 5 == 0)
                return n == 5;

            int i;
            int temp = (int)Math.Sqrt(n);
            for (i = 7; i <= temp; i += 2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}

//Convert.ToInt(Object value):将Object类型转换为int类型，且四舍六入，中间取偶（比如：4.5=4,5.5=6），null取0
//int.Parse(string value):只能将string类型转换为int类型，小数报错,null报错
//(int):将数值类型强制转换为整型，若是小数则向左取整