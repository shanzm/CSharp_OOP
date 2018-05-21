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
        public string Name///如果不需要在属性的set和get访问模块设置取值，则可以直接抛弃
                          ///字段，在属性中直接，写只set和get，但是这样其实也是很没有意义的
                          ///你想想，属性的作用是什么？属性作用是是为了限制字段的取值
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

    }
}
