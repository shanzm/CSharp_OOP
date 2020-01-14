#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    DiscountRate
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-8 21:50:56
// Update Time         :    2018-5-8 21:50:56
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    
    class DiscountRate:DiscountFather
    {
        public double Rate//属性
        {
            set;
            get;
        }

        public DiscountRate(double rate)//构造函数
        {
            this.Rate = rate;
        }

        public override double GetToalMoney(double realMoney)
        {
            //realMoney = realMoney * this.Rate;
            //return realMoney;
            return realMoney * this.Rate;
        }
    }
}
