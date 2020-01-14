#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    Napkin
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-7 22:19:04
// Update Time         :    2018-5-7 22:19:04
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
    class Napkin:ProductFather 
    {
        public Napkin(string id, double price, string name)
            : base(id, price, name )
        {
        }
    }
}
