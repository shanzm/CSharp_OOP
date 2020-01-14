using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 知识点补充_对象初始化器
{
    class Program
    {
        static void Main(string[] args)
        {
            //数组初始化快捷方式
            int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            //集合快速初始化
            List<int> list = new List<int>();
            list.AddRange(new int[] { 0, 1, 2, 4, 5, 6, 7 });
            //更快速的初始化器
            List<int> list2=new List<int> (){0,1,2,3,4,5,6,7};

            //对象初始化器
            Person p=new Person() {Name ="张三",Age=25,Gender='男'};//不常用
        }
    }



    public class Person
    {

        public string Name
        {

            set;
            get;
        }

        public int Age
        {

            set;
            get;
        }

        public char Gender
        {

            set;
            get;
        }
    }
}
