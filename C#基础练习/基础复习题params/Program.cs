using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础复习题_params
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = GetMax(1, 2, 3);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static int GetMax(params int[] nums)
        {
            int Max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > Max)
                {
                    Max = nums[i];
                }
            }
            return Max;
        }

    }
}
