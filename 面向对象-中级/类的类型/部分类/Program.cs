using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 部分类
{
    class Program
    {
        /// <summary>
        /// 什么是部分类呢？
        /// 部分类是指将一个类写成多部分，有利于多人共同开发项目
        /// 使用关键字partial
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Person p = new Person("张三",25);
            Console.WriteLine("{0}，{1}", p.Name, p.Age);
            Console.ReadKey();
        }


        //Person类的一部分
        public partial class Person
        {
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
        }

   
        //Person类的一部分
        public partial class Person
        {
            public Person(string name, int age)
            {
                this._name = name;
                this._age = age;
            }


            private int _age;


            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }
        }

    }
}