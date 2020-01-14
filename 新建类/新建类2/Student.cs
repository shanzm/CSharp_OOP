#region 
// ===============================================================================
// Project Name        :    面向对象练习
// Project Description :   
// ===============================================================================
// Class Name          :    Student
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-4-14 22:14:25
// Update Time         :    2018-4-14 22:14:25
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    public class Student
    {
        //字段、属性、方法、构造函数
        /*什么是构造函数？
         1、构造函数是一种特殊的方法，，哪怕是返回值为空，也不需要写void
         2、构造函数的名称必须和类名一样。
         3、构造函数在类中，在实例化对象时最先运行的
         4、构造函数有什么用呢？构造函数主要的作用就是初始化对象、
         * 举个例子，来说，你要是创建了一个对象，但是有好多这样的具体对象
         * 你每一个都进行实例化，就会显得很麻烦，代码很冗余。
         */


        //构造函数1
        public Student(string name, char gender, int age,
            int chinses, int math, int english)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Chinses = chinses;
            this.Math = math;
            this.English = english;
        }

        //构造函数一般是要重载函数的——重载函数2
        public Student(string name, int chinses, int math, int english)
        {
            this.Name = name;
            this.Chinses = chinses;
            this.Math = math;
            this.English = english;

        }

        /*重载函数3，此时你应该发现了，为了写重载函数，代码有许多重复的，即代码冗余
        我们可以采用以下方式避免代码的冗余*/
        //这个是该重载函数调用上面第二个重载函数中，使用的this语句
        //this相当于上面第二个重载函数，其中数学和英语的成绩在此后默认写为0,0
        public Student(string name, int chinses):this( name,chinses,0,0)
        {

        }




        string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set { _name = value; }
        }

        char _gender;
        public char Gender
        {
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }

                _age = value;
            }
        }

        int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        int _english;
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }

        int _chinses;
        public int Chinses
        {
            get { return _chinses; }
            set { _chinses = value; }
        }


        public void SayHello()
        {
            Console.WriteLine("我是{0}，我今年{1}岁，我是{2}生",
                this.Name, this.Age, this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我的语文成绩是{0}\n，我的总成绩是{1}\n，我的平均成绩是{2}\n",
                this.Chinses, this.Math + this.Chinses + this.English,
                (this.Math + this.Chinses + this.English) / 3);
        }


    }
}
