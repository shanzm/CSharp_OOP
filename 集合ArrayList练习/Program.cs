using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace 集合ArrayList练习
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            int sum = 0;
            double avg = 0;
            for (int i = 0; i < myList.Count; i++)
            {
                sum += (int)myList[i];///注意此处，你要记住因为集合是不限制元素类型的，所以
                                      ///集合中的每一个元素都是object类型的，而object类型是、
                                      ///c#中所有类型的父类（基类），根据里氏转换原则，父类中
                                      ///存储的是子类对象时，是可以强制转换为对应的子类型的
            }
            avg = sum / (myList.Count);
            Console.WriteLine("总和：{0}，平均数{1}", sum, avg);
            Console.ReadKey();
        }
    }
}
