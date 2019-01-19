using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扩展方法
{

    //细节说明
    //1. 声明扩展方法的类必须是静态类。
    //2. 扩展方法本身必须声明为static
    //3. 扩展方法必须包含关键字this 作为他的第一个参数类型, 并在后面跟着他所要扩展的类的名称

    public sealed class Person
    {
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        string _name;
        public string Name
        {
            set;
            get;
        }


        private int _age;
        public int Age
        {
            get;
            set;
        }

        string _gender;
        public string Gender
        {
            get;
            set;
        }

        //介绍自己姓名和性别
        public void IntroductGender()
        {
            Console.WriteLine($"我是{this.Name}，我是一个{this.Gender}生");
        }
    }

    //定义一个类这个类是静态类，其中有一个静态方法IntroductAge()，这个方法就是我们想要关联到Person类的方法
    public static class extendPerson
    {
        public static void IntroductAge(this Person p)
        {
            Console.WriteLine($"我是{p.Name},我的年龄是{p.Age}");


        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("小明", 24, "男");

            p.IntroductGender();

            p.IntroductAge();

            Console.ReadKey();
        }
    }

}
