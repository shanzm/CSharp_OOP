using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;//集合类的命名空间


namespace 集合ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            //集合添加单个元素
            myList.Add(1);//添加一个整型
            myList.Add(true);//添加一个布尔型变量
            myList.Add(3.14);//添加一个double类型
            myList.Add("张三");//添加一个字符串类型
            myList.Add('a');//添加一个char类型

            //集合添加集合类型
            //myList.AddRange(new int[] { 1, 2, 3, 4 });//添加一个数组
            //myList.AddRange(myList);//添加一个集合（此处添加的是该集合本身）
              
           // myList.Insert(2,"插入的元素");


            foreach (object  item in myList )//注意使用的是object类型，因为ArrayList中能够存储所有类型就是因为，他把所有变量存储为他们的父类object类型
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < myList.Count; i++)
            //{

            //    Console.WriteLine(myList[i]);
            //}
            int 长度 = myList.Count;
            Console.WriteLine(长度);
            Console.ReadKey();


            //int 长度 = myList.Count; //集合的长度
            //myList.Clear();//删除集合中所有的元素
            //myList.Remove(1);//删除集合中元素“1”；
            //myList.RemoveAt(2);//删除集合中下标为2的元素
            //myList.RemoveRange(0, 3);//删除下标0到2的元素，注意是不包含下标为3的元素
            //myList.Sort();//对集合中元素进行升序排列,当然这就要求数组中的元素是可以相互比较的
            //myList.Reverse();//将集合中所有的元素进行翻转排序
            //myList.Insert(2，"插入");//在指定的索引处（此处是在第二个元素————之前————插入）插入一个值，也就是插入之后元素“插入”处于第二个元素的位置
            //myList.InsertRange(2, new int[] { 1, 2, 3, 4, 5 });//在指定的索引处插入一个数组
         
        }
    }
}
