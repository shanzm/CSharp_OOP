#region
// ===============================================================================
// Project Name        :    ProFactory
// Project Description :   
// ===============================================================================
// Class Name          :    Factory
// Class Version       :    v1.0.0.0
// Class Description   :   
// Author              :    shanzm
// Create Time         :    2018-6-11 17:48:24
// Update Time         :    2018-6-11 17:48:24
// ===============================================================================
// Copyright © SHANZM-PC 2018 . All rights reserved.
// ===============================================================================
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProOperation;
using System.IO;
using System.Reflection;

namespace ProFactory
{
    /// <summary>
    /// 简单工厂模式，这和我们之前做的不一样就在于我们是从dll 文件中获得运算符号type
    /// 我们在Debug文件夹下面新添加了一个Plug文件。里面放所有的运算符的dll文件
    /// 
    /// 最终返回一个Operation类型但装着他子类类型的对象
    /// </summary>
    public class Factory
    {
        public static Operation GetOperator(string type, double  num1, double  num2)
        {

            Operation op = null;

            //动态的获得程序集ProAdd.dll
            //获取了文件夹Plug的路径
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plug");
            //获取文件夹Plug下面的所有程序集的全路径
            //有ProAdd.dll,ProSub.dll,ProMul.dll,ProDiv.dll四个dll文件的路径
            string[] filespath = Directory.GetFiles(path, "*.dll");

            foreach (string item in filespath)
            {
                //通过绝对路径加载程序集
                Assembly ass = Assembly.LoadFile(item);
                //获得程序集中公开的类的类型
                Type[] types = ass.GetExportedTypes();
                foreach (Type tt in types)
                {
                    //判断该类是Operation的子类，不是抽象类则创建对象
                    //整个程序集只有我们自己创建的那个类符合这个条件
                    if (tt.IsSubclassOf(typeof(Operation)) && !tt.IsAbstract)
                    {
                        op = (Operation)Activator.CreateInstance(tt, num1, num2);
                    }

                }

                if (type == op.Type)//if (op.GetType().ToString () ==type)
                {
                    break;
                }
                 else
                {
                    op = null;
                }

            }

            return op;

        }
    }
    ///使用下面的方法也可以，但是要把所有的扩展dll文件放在Debug文件夹下。

    //public class Factory
    //{

    //    public static  Type GetType(string assemblyName)
    //    {
    //        Type t = null;
    //        Assembly ass = Assembly.Load(assemblyName);
    //        Type[] types = ass.GetExportedTypes();
    //        foreach (Type item in types)
    //        {
    //            if (item.IsSubclassOf(typeof(Operation)) && !item.IsAbstract)
    //            {
    //                t = item;
    //            }

    //        }
    //        return t;
    //    }

    //    public static Operation GetOperator(string type, double num1, double num2)
    //    {


    //        Operation op = null;
    //        switch (type)
    //        {


    //            case "+":
    //                op = (Operation)Activator.CreateInstance(GetType("ProAdd"), num1, num2);
    //                break;
    //            case "-":
    //                op = (Operation)Activator.CreateInstance(GetType("ProSub"), num1, num2);
    //                break;
    //            case "*":
    //                op = (Operation)Activator.CreateInstance(GetType("ProMul"), num1, num2);
    //                break;
    //            case "/":
    //                op = (Operation)Activator.CreateInstance(GetType("ProDiv"), num1, num2);
    //                break;

    //        }
    //        return op;
    //    }
    //}
}
