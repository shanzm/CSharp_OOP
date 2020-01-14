#region
// ===============================================================================
// Project Name        :    超市收银系统
// Project Description :   
// ===============================================================================
// Class Name          :    Warehouse
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-5-7 22:25:29
// Update Time         :    2018-5-7 22:25:29
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
    /// <summary>
    /// 注意 new List<List<ProductFather>>();相当于是一个仓库
    /// new List<ProductFather>();相当于一个货架
    /// </summary>
    class Warehouse
    {
        //存储货物
        List<List<ProductFather>> wh = new List<List<ProductFather>>();


        public Warehouse()//构造函数
        {
            wh.Add(new List<ProductFather>());//作为货架Warehouse[0],存储Acer
            wh.Add(new List<ProductFather>());//作为货架Warehouse[1],存储SamSung
            wh.Add(new List<ProductFather>());//作为货架Warehouse[2],存储Banana
            wh.Add(new List<ProductFather>());//作为货架Warehouse[3],存储Napkin
        }


        public void ShowPros()
        {
            foreach (var item in wh )//item是List<ProductFather>()，即货架
            {
                Console.WriteLine("超市有{0},有{1}个,每个单价为{2}元。", item[0].Name,item.Count ,item [0].Price );
            }
        }

        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        public void InputPros(string strType, int count)
        {
            //注意这个count，是指来了一车货，里面有香蕉，宏基，三星，餐巾纸，不分种类总共有100件（这就是count）
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": wh[0].Add(new Acer(Guid.NewGuid().ToString(), 5000, "宏基电脑")); //此处要说明一个静态类Guid，他的方法NewGuid();生成一个很长但是独一无二的编号，我们使用ToString();把这个编号转化为一个字符串类型
                        break;

                    case "SamSung": wh[1].Add(new SamSung(Guid.NewGuid().ToString(), 2500, "三星手机"));
                        break;

                    case "Napkin": wh[2].Add(new Napkin(Guid.NewGuid().ToString(), 5, "餐巾纸"));
                        break;

                    case "Banana": wh[3].Add(new Banana(Guid.NewGuid().ToString(), 10, "香蕉"));
                        break;
                }
            }

        }

        /// <summary>
        /// 从仓库取货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">货物数量</param>
        /// <returns></returns>
        public ProductFather [] OutputPros(string strType, int count)
        {
            ProductFather[] Pros = new ProductFather[count];
            for (int i = 0; i < Pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer": Pros[i] = wh[0][0];///Warehouse[0][0],Warehouse[0]是存储Acer的货架，Warehouse[0][0]是货架上的第一个元素
                        wh[0].RemoveAt(0);
                        break;
                    case "SamSung": Pros[i] = wh[1][0];
                        wh[1].RemoveAt(0);
                        break;
                    case "Napkin": Pros[i] = wh[2][0];
                        wh[2].RemoveAt(0);
                        break;
                    case "Banana": Pros[i] = wh[3][0];
                        wh[3].RemoveAt(0);
                        break;

                }
            }
            return Pros;
        }
    }
}
