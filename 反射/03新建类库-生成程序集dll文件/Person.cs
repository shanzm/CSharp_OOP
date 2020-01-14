#region
// ===============================================================================
// Project Name        :    Common
// Project Description :   
// ===============================================================================
// Class Name          :    Person
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-10 15:33:27
// Update Time         :    2018-6-10 15:33:27
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    /// <summary>
    /// 注意这个项目是类库类型
    /// 我们新建一个类库，一般我们不用其自带的Class.cs这个类
    /// 我们可以在这个项目中自己添加新的类，这个类库项目的所有类最终都会编译到程序集文件Common.dll中
    /// 
    /// 注意类库项目用来生成dll文件的，不能运行，要点击“生成”
    /// </summary>
    public class Person
    {
        public string Name { get; set; }

        public char Gender { get; set; }

        public int Age { get; set; }

        public Person(string name, char gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

       

        public void Do()
        {

            Console.WriteLine("123454567899");
        }

    }
}
