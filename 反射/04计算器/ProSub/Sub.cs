#region
// ===============================================================================
// Project Name        :    ProSub
// Project Description :   
// ===============================================================================
// Class Name          :    Sub
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-12 13:56:42
// Update Time         :    2018-6-12 13:56:42
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProOperation;

namespace ProSub
{
   public  class Sub:Operation
    {
       public Sub(double num1, double num2)
           : base(num1, num2)
       {
       }

        public override string Type
        {
            get { return "-"; }
        }

        public override double GetResult()
        {
            return this.Num1 - this.Num2;
        }
    }
}
