#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    DiscountForFree
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-8 22:03:09
// Update Time         :    2018-5-8 22:03:09
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
    class DiscountMForN:DiscountFather
    {
        public double M
        {
            set;
            get;
        }

        public double N
        {
            set;
            get;
        }
        public DiscountMForN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }

        /// <summary>
        /// 满M元减N元
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetToalMoney(double realMoney)
        {
            if (realMoney >=this.M )
            {
                return (realMoney -this.N *(int)(realMoney/this.M));
                
                ///注意
                ///int/int=int，
                ///double/int=double，
                ///int/double=double，
                ///double/double=double
            }
            else
            {
                return realMoney;
            }
        }
    }
}
