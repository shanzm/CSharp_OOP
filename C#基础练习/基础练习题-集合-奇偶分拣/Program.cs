using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础练习题_集合_奇偶分拣
{
    class Program
    {
        /// <summary>
        /// 将数组中的数字分拣成奇数和偶数，在从新放在数组中，奇数在前，偶数在后
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> listJi = new List<int>();
            List<int> listOU = new List<int>();

            foreach (int item in num)
            {
                if (item % 2 == 0)
                {
                    listOU.Add(item);
                }

                else
                {
                    listJi.Add(item);
                }
            }
            listJi.AddRange(listOU);
            foreach (int item in listJi)
            {
                Console.Write(item);
            }
            Console.ReadKey();
            
          
        }
    }
}
