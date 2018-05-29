#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    DiscountNormal
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-8 21:27:46
// Update Time         :    2018-5-8 21:27:46
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
    class DiscountNormal:DiscountFather
    {
        /// <summary>
        /// 不打折
        /// </summary>
        /// <param name="realMoney">真是价格</param>
        /// <returns>真实价格</returns>
        public override double GetToalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
