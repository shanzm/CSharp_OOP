#region
// ===============================================================================
// Project Name        :    ProMul
// Project Description :   
// ===============================================================================
// Class Name          :    Mul
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-12 22:52:30
// Update Time         :    2018-6-12 22:52:30
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProOperation;


namespace ProMul
{
    public class Mul : Operation
    {
        public Mul(double num1, double num2)
            : base(num1, num2)
        {

        }

        public override string Type
        {
            get { return "*"; }
        }

        public override double GetResult()
        {
            return this.Num1 * this.Num2;
        }
    }
}
