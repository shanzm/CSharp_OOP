using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 基础复习题_生成指定数目的不同的随机数
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[] randomArray = getRandomNum(3, 1, 10);
            foreach (int item in randomArray)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
        public static int[] getRandomNum(int num, int minValue, int maxValue)
        {
            Random ra = new Random((int)DateTime.Now.Ticks);//随机种子使用的当前时间，
            int[] arrNum = new int[num];
            int temp = 0;
            for (int i = 0; i < num; i++)
            {
                temp = ra.Next(minValue, maxValue);//在指定的范围取随机数
                arrNum[i] = getNum(arrNum, ra, temp, minValue, maxValue);
            }
            return arrNum;
        }


        /// <summary>
        /// 新生成的随机数和数组中进行比较
        /// </summary>
        /// <param name="arrNum">随机数存放的数组</param>
        /// <param name="ra">随机对象</param>
        /// <param name="temp">新生成的随机数</param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static int getNum(int[] arrNum, Random ra, int temp, int minValue, int maxValue)
        {
            int n = 0;

            while (n <= arrNum.Length - 1)
            {
                if (temp == arrNum[n])//若是重复，则重新生成随机数
                {
                    temp = ra.Next(minValue, maxValue);//注意我们一定要使用原来的随机对象ra来生成
                    getNum(arrNum, ra, temp, minValue, maxValue);//递归：如果取出来的数字和已取得的数字有重复就重新随机获取
                }
                n++;
            }

            return temp;
        }
    }
}
