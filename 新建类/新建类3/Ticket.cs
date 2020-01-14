#region
// ===============================================================================
// Project Name        :    面向对象练习2
// Project Description :   
// ===============================================================================
// Class Name          :    Ticket
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-4-15 13:25:15
// Update Time         :    2018-4-15 13:25:15
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习2
{
    class Ticket
    {
       



        private int _distance;
        public int Distance//设置为只读属性
        {
            get
            {
                if (_distance < 0)
                {
                    return _distance = 0;
                }
                return _distance;
            }
        }

        public Ticket(int distance,double price)//构造函数，主要是为字段赋值初始化，
        //不要把其他功能放在这里,其他功能通过建立新的方法中
        {
           
            this._distance = distance;
            this._price = price;
        }

        private double _price;
        public double Price
        {
            set { _price = value; }
            get
            {
                if (_distance < 0)
                {
                    return 0;
                }
                if (_distance >= 0 && _distance < 100)
                {
                    return _price;
                }
                else if (_distance >= 100 && _distance < 200)
                {
                    return _price * 0.95;//打九五折
                }
                else if (_distance >= 200)
                {
                    return _price * 0.8;//打八折
                }
                else
                {
                    return _price;
                }
            }
        }
     
        public void ShowTicket()
        {
            Console.WriteLine("price:{0}", Price*Distance  );
           
        }
    }
}
