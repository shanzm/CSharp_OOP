#region
// ===============================================================================
// Project Name        :    ProOperation
// Project Description :   
// ===============================================================================
// Class Name          :    Operation
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-11 17:20:08
// Update Time         :    2018-6-11 17:20:08
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProOperation
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class Operation 
    {
        public double Num1 { set; get; }

        public double Num2 { set; get; }

        public Operation(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        /// <summary>
        /// 记录子类的运算符号，是只读的，我们使用配置文件给他赋值
        /// </summary>
        public abstract string Type { get; }


        public abstract double GetResult();
       
    }
}
