using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 新建类
{
    class Program
    {
        static void Main(string[] args) 
        {
            Person p0 = new Person();//使用的是无参构造函数
            p0.Name = "志铭";
            p0.Age = 24;
            p0.Gender = "不告诉你";
            p0.Introduct();

            Person p1 = new Person("单志铭", 25);
            p1.Introduct();

            Person p2 = new Person("女");
            p2.Introduct();

            Console.ReadKey();
        }
    }
}
