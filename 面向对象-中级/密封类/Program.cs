using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using 新建类;


namespace 密封类
{
    class Program
    {
        /// <summary>
        /// 什么是密封类呢？
        /// 你若是不想让一个类当父类（就是不能被其他类继承），就可以把它定义为密封类，使用关键字seald
        /// 注意密封类，不能被继承，但是可以继承于其他类
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        }

        public sealed class Student:Person//注意此处继承于项目“新建类”中的Person类
        {
            private int _num;

            public int Num
            {
                get { return _num; }
                set { _num = value; }
            }

        }

        //public class student1 : Student///注意这样就会报错，应为无法从密封类派生（也就是密封类不可以被继承）
        //{
        //}

    }
}
