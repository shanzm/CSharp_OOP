using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02反射常用的函数
{
    class Program
    {
        static void Main(string[] args)
        {
            //判断Person类型的变量可不可以接受Student类型的变量的赋值，返回是布尔类型
            bool b1 = typeof(Person).IsAssignableFrom(typeof(Student));//这里结果是True

            Student s = new Student();
            Person p = new Person();          
            //判断对象是不是类或接口的实例
            bool b2 = typeof(Student).IsInstanceOfType(s);    //返回值是True
            bool b3 = typeof(Person).IsInstanceOfType(s);     //返回值是True，因为对象s是Student类的，是Person的子类
            //bool b3 = p.GetType().IsInstanceOfType(s);      //在已经存在对象的时候可以使用GetType获取对象类型
            bool b4 = typeof(Student).IsInstanceOfType(p);    //返回值是False
            bool b5 = typeof(ISayable).IsInstanceOfType(s);   //返回值是True      

            //判断对象是不是类的子类（注意和IsInstanceOfType不同之处就是，他不能判断是不是接口的子类
            //而且注意他的参数的顺序
            bool b6 = s.GetType().IsSubclassOf(typeof(Person));//返回值是True
            bool b7 = s.GetType().IsSubclassOf(typeof(Student));//返回值是False，s是Student类的对象，不是Student的子类对象

            Console .WriteLine ("b1:{0},\nb2:{1},\nb3:{2},\nb4:{3},\nb5:{4},\nb6:{5}",b1,b2,b3,b4,b5,b6);
            Console.ReadKey();
        }
    }

    class Person
    { }

    class Student : Person,ISayable 
    {
      public  void Test()
        {
            return ;
       }
    }

    class Teacher
    { }

    interface ISayable
    {
        void Test();
    }

}
