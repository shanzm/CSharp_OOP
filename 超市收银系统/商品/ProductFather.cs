#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    ProductFather
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-7 22:02:53
// Update Time         :    2018-5-7 22:02:53
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
    class ProductFather
    {

        public string ID
        {
            set;
            get;
        }

        public double Price
        {
            set;
            get;
        }

        public String  Name
        {
            set;
            get;
        }

        public ProductFather(string id, double price, String name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
