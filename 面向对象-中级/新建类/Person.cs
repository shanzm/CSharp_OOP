#region
// ===============================================================================
// Project Name        :    新建类
// Project Description :   
// ===============================================================================
// Class Name          :    Person
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-4-13 12:00:47
// Update Time         :    2018-4-13 12:00:47
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 新建类
{
    public class Person
    {
        //string _name;//字段

        //public string Name//属性
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        ///【注意】输入字段之后快速自动生成属性的方法
        ///1.输入prop，按Tap两次，但是这样之后还要自己进行属性名称的修改
        ///2.使用快捷键Ctrl+r+e,之后回车；
        ///3.编写完字段之后右键-->快速操作与重构

        public string Name///如果不需要在属性的set和get访问模块设置取值，则可以直接抛弃
                          ///字段，在属性中直接，写只set和get，这就称之为自动属性
        {
            set;
            get;
        }


        private int _age;//字段,其实不写private也可以，就是默认的private
        public int Age
        {
            get { return _age; }
            set
            {
                if (_age <= 0 || _age >= 100)
                {
                    _age = 0;
                }

                _age = value;
            }
        }

        string _gender;
        public string Gender
        {

            get
            {
                if (_gender != "男" && _gender != "女")
                {
                    return _gender = "男(default）";
                }
                return _gender;
            }
            set { _gender = value; }
        }

        public void Introduct()
        {
            Console.WriteLine("我是{0}，我的年龄是{1}，我是一个{2}生，你好！", this.Name, this.Age, this.Gender);
        }

        #region this
        // 保留字 this 仅限于在构造函数 类的方法和类的实例中使用 它有以下含义:

        //1.作为当前类的实例对象

        //2.作为类中构造函数的重构函数的串联函数

        
        #endregion

        #region base
        //1.子类中调用父类的字段、属性等

        //2.子类中继承父类的构造函数

        #endregion
    }
}
