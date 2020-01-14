using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 5, 7, 2, 3, 6, 8, 9, 0 };


            ///冒泡排序
            //for (int i = 0; i < nums.Length ; i++)///强烈建议记住i取值
            //{
            //    for (int j = 0; j < nums.Length -i-1; j++)///强烈建议记住j取值
            //    {
            //        if (nums[j]>nums[j+1])///注意此处>，上一个比，下一个大，则换位，表示升序排列
            //                              ///降序排列只需将此处改为<
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp ;
            //        }
            //    }
            //}

            Array.Sort(nums);//数组类Array中的sort方法就可以实现数组的排序，但是只能进行升序排序
            //怎么实现降序排序呢？那就先升序再颠倒
            Array.Sort(nums);
            Array .Reverse (nums);





            foreach (int  item in nums)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            
        }

        
    }
}
