#region
// ===============================================================================
// Project Name        :    Common
// Project Description :   
// ===============================================================================
// Class Name          :    Student
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-10 15:35:55
// Update Time         :    2018-6-10 15:35:55
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
    /// 注意这个类我们没有加访问修饰符，默认是internal的
    /// </summary>
    class Student : Person
    {
        public int Score { get; set; }

        public int Id { get; set; }

        public Student(string name, char gender, int age, int score, int id)
            : base(name, gender, age)
        {
            this.Score = score;
            this.Id = id;
        }

        public void Sayhi()
        {
            Console.WriteLine("你好");
        }
    }
}
