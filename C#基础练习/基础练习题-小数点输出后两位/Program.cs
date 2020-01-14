using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_小数点输出后两位
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = { 1.786, 2, 3, 5.6 };

            ////法1--你要是想要无论如何都是显示两位小数，只能用此法
            double avg1 = GetAvg(nums);
            Console.WriteLine("{0:0.00}", avg1);//结果是3.10

            ////法2--保留两位小数，但是末尾是0 ，就省略了
            double avg2 = GetAvg(nums);
            avg2 = Convert.ToDouble(avg2.ToString("0.00"));//结果是3.1，因为又转成double类型，0就不写了
            Console.WriteLine(avg2);

            ////法3--保留两位小数，但是末尾是0 ，就省略了
            double avg3 = GetAvg(nums);
            avg3 = Math.Round(avg3, 2);
            Console.WriteLine(avg3);//结果是3.1

            Console.ReadKey();
        }

        public static double GetAvg(params double[] args)
        {
            double sum = 0;
            foreach (double item in args)
            {
                sum += item;
            }
            return sum / args.Length;
        }
    }
}
