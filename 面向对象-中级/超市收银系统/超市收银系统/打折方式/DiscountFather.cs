#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    DiscountFather
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-8 21:22:59
// Update Time         :    2018-5-8 21:22:59
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
    abstract class DiscountFather
    {
        /// <summary>
        /// 计算打折后的应付的钱
        /// </summary>
        /// <param name="realMoney">打折前应付的钱</param>
        /// <returns>打折后应付的钱</returns>
        public abstract double  GetToalMoney(double realMoney);

    }
}
