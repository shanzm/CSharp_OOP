using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 继承
{
    class Program
    {

        //Ctrl + M + O: 折叠所有方法

        //Ctrl + M + M: 折叠或者展开当前方法

        //Ctrl + M + L: 展开所有方法
        static void Main(string[] args)
        {
            Person zs = new Person("张三", '男', 25);
            zs.Doing();


            Student studentLs = new Student("张三", '男', 25, 0001);
            studentLs.Doing();
            studentLs.Doing();

            Teacher teacherWw = new Teacher("王五", '男', 25, 3200);
            teacherWw.Doing();
            teacherWw.Calling();

            EnglishTeacher Zl = new EnglishTeacher("周六", '男', 25, 3500, 425);
            Zl.Calling();
            Zl.habbit();

            Console.ReadKey();
        }
    }


    public class Person//父类
    {

        public Person(string name, char gender, int age)
        {
            this.Name = name;///此处不要写作this._name=name,要通过属性Name来赋值初始化，
                             ///因为你要记得属性的作用就是用来限制字段取什么样的值的，字段
                             ///一切的数据交换都有属性作为中间人
            this.Gender = gender;
            this.Age = age;
        }
        string _name;
        public string Name
        {
            set;
            get;
        }
        
        char _gender;
        public char Gender
        {
            set;
            get;
        }

        int _age;
        public int Age
        {
            set;
            get;
        }

        public void Doing()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }

    class Student : Person
    {
        public Student(string name, char gender, int age, int id)
            : base(name, gender, age)
        {
            this.Id = id;
        }

        int _id;
        public int Id
        {
            set;
            get;
        }



        public new void Doing()//如果你定义的子类中有和父类同名的方法，那没子类对象就调用不到父类中的同名函数了，父类中的同名函数被子类中的同函数隐藏了,此时编译器会提出警告，”若有意隐藏父类中的同名函数，请使用new关键字，即 public  new  void Doing()
        {
            Console.WriteLine("学习");
        }
    }

    public class Teacher : Person
    {

        public Teacher(string name, char gender, int age, double salary)
            : base(name, gender, age)
        {
            this.Salary = salary;
        }


        double _salary;
        public double Salary
        {
            set;
            get;
        }



        public void Calling()
        {
            Console.WriteLine("教学");
        }
    }

    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name, char gender, int age, double salary,
            double englishScores)
            : base(name, gender, age, salary)
        {
            this.EnglishScores = englishScores;
        }


        double _englishScores;
        public double EnglishScores
        {
            set;
            get;
        }


        public void habbit()
        {
            Console.WriteLine("英语成绩{0}", EnglishScores);
        }
    }
}