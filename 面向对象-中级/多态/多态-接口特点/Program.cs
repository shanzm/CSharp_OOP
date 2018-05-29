using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口特点
{
    class Program
    {
        /// <summary>
        /// 接口与接口之间可以继承，并且可以多继承。
        ///接口并不能去继承一个类，而类可以继承接口  （接口只能继承于接口，而类既可以继承接口，也可以继承类）
        ///一个类可以同时继承一个类并实现多个接口，如果一个子类同时继承了父类A，并实现了接口IA,那么语法上A必须写在IA的前面。
        ///class MyClass:A,IA{}，因为类是单继承的。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }
        
        /// <summary>
        /// 类
        /// </summary>
      
        public class Student :Person, AllinterfaceIrunable//注意//一个类可以同时继承一个类并实现多个接口，如果一个子类同时继承了父类A，并实现了接口IA,那么语法上A必须写在IA的前面。
        {

            public void run()
            {
                throw new NotImplementedException();
            }

            public void swim()
            {
                throw new NotImplementedException();
            }

            public void eat()
            {
                throw new NotImplementedException();
            }
        }


        public class Person
        {
            public void Say()
            {
                Console.WriteLine("我是人");
            }
        }

        /// <summary>
        /// 接口
        /// </summary>
        /// 

        public interface Irunable
        {
            void run();
        }

        public interface Iswimable
        {
            void swim();
        }

        public interface Ieatable
        {
            void eat();
        }

        public interface AllinterfaceIrunable:Irunable ,Iswimable ,Ieatable //注意/// 接口与接口之间可以继承，并且可以多继承。
        {

        }
    }
}
