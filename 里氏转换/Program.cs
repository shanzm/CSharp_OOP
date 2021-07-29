using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 里氏转换原则
            Person p = new Person();
            Student s = new Student();
            Teacher t = new Teacher();
            Driver d = new Driver();


            Person[] personArray = new Person[10];
            Random r = new Random();
            for (int i = 0; i < personArray.Length; i++)
            {
                int rNumber = r.Next(1, 5);
                switch (rNumber)
                {

                    ///里氏转换——子类对象可以赋值给父类对象
                    case 1: personArray[i] = p; break;
                    case 2: personArray[i] = s; break;
                    case 3: personArray[i] = t; break;
                    case 4: personArray[i] = d; break;
                }
            }
            for (int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i] is Student)
                {
                    ///里氏转换——父类对象可以强制转换为子类对象
                    //((Student)personArray[i]).SayHello();

                    //这里可以使用as关键字
                    (personArray[i] as Student).SayHello();
                }
                else if (personArray[i] is Teacher)
                {
                    ((Teacher)personArray[i]).SayHello();
                }
                else if (personArray[i] is Driver)
                {
                    ((Driver)personArray[i]).SayHello();
                }
            }
            #endregion



            Console.ReadKey();


        }

        public class Person
        {
            public void SayHello()
            {
                Console.WriteLine("我是人");
            }
        }

        public class Student : Person
        {
            public new void SayHello()
            {
                Console.WriteLine("我是学生");
            }
        }

        public class Teacher : Person
        {
            public new void SayHello()
            {
                Console.WriteLine("我是老师");
            }
        }

        public class Driver : Person
        {
            public new void SayHello()
            {
                Console.WriteLine("我是司机");
            }
        }




    }
}
