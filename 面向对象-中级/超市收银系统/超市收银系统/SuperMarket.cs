#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    SuperMarket
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-8 20:16:12
// Update Time         :    2018-5-8 20:16:12
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
    class SuperMarket
    {
        Warehouse wh = new Warehouse();

        /// <summary>
        /// 创建超市对象时，自动给仓库的货架上导入货物
        /// </summary>
        public SuperMarket()//SuperMarket类的构造函数
        {
            wh.InputPros("Acer", 1000);
            wh.InputPros("SamSung", 1000);
            wh.InputPros("Napkin", 1000);
            wh.InputPros("Banana", 1000);
        }

        /// <summary>
        /// 和用户交互的过程
        /// </summary>
        public void AskBuying()
        {
            Console.WriteLine("欢迎，你需要什么？");
            Console.WriteLine("我们这里有Acer，SamSung，Napkin，Banana");
            String strType = Console.ReadLine();
            Console.WriteLine("你需要多少？");
            int count = Convert.ToInt32(Console.ReadLine());

            //去仓库取货
            ProductFather[] pros = wh.OutputPros(strType, count);
            double realMoney = GetMoney(pros);
            Console.WriteLine("你总共需付{0}元钱", realMoney);
            Console.WriteLine("请选择你需要的打折方式：1.不打折，2.打九折，3.打85折，4.买300减50,5.买500减100 ");
            string input = Console.ReadLine();

            //其实这就是简单工厂模式的实现，我们将打折方式抽象了一个父类，在实现GetDiscount（）方法时就是
            //使用的工程模式，获得了用户的打折方式；
            DiscountFather disocuntWay = GetDiscount(input);
            double totalMoney = disocuntWay.GetToalMoney(realMoney);
            Console.WriteLine("打完折后总计：{0}", totalMoney);
            Console.WriteLine("你的购物清单：");
            foreach (var item in pros )
            {
                Console.WriteLine("种类：{0}   单价{1}    货物条形码{2}", item.Name, item.Price, item.ID);
                
            }
            Console.WriteLine("------------------------------------------------------------------------" + "\n" + "total:{0}", totalMoney);

        }

        /// <summary>
        /// 根据用户的输入选择一个打折方式
        /// 这里使用的就是典型的--简单工厂模式
        /// </summary>
        /// <param name="input">打折方式</param>
        /// <returns>f返回一个打折父类类型，但是装的一定是一个子类类型的对象</returns>
        public DiscountFather GetDiscount(string input)
        {
            DiscountFather discountWay = null;//注意这个DiscountFather是一个抽象类，不能实例化
            switch (input)
            {
                case "1": discountWay = new DiscountNormal();
                    break;
                case "2": discountWay = new DiscountRate(0.9);
                    break;
                case "3": discountWay = new DiscountRate(0.85);
                    break;
                case "4": discountWay = new DiscountMForN(300, 50);
                    break;
                case "5": discountWay = new DiscountMForN(500, 100);
                    break;
            }
            return discountWay;
        }


        /// <summary>
        /// 计算所有货物的初试总价格
        /// </summary>
        /// <param name="pros">购物车</param>
        /// <returns>初试总价</returns>
        public double GetMoney(ProductFather[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }
            return realMoney;
        }

        /// <summary>
        /// 调用Warehouse中的展示商品的函数ShowPros
        /// </summary>
        public void ShowPros()
        {
            wh.ShowPros();
        }

      
    }
}
