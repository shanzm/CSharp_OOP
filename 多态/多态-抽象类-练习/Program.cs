using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态_抽象类_练习
{
    /// <summary>
    /// 使用多态实现求圆形和矩形的面积和周长
    /// 1.要是用多态，你首先的抽象出一个父类——形状，
    /// 但是你不知道形状中的求面积和求周长的方法怎么写（因为矩形和圆的面积周长都不一样）
    /// 所以你只能使用抽象类的方法实现多态
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Circle c1 = new Circle(1);
            //Squareness s1=new Squareness(1,2);//如果你这样写，多态的意义就没了
            Shape c1 = new Circle(1);
            Shape s1 = new Squareness(1, 2);
            Console.WriteLine("圆形面积{0}，周长{1}",c1.GetArea(),c1.GetPerimeter ());
            Console.WriteLine("矩形面积{0}，周长{1}", s1.GetArea(), s1.GetPerimeter());
            Console.ReadKey();

        }

        public abstract class Shape
        {
            public abstract double GetArea();//参数你也没法写啊，因为圆和矩形的求面积公式不一样
                                             //所以你只能把这些写在子类中，在子类中定义相应的字段
            public abstract double GetPerimeter();
        }

        public class Circle : Shape//自动生成重写函数ctrl+alt+f10
        {
            private double _radii;//字段

            public double Radii//属性ctrl+r+e
            {
                get { return _radii; }
                set { _radii = value; }
            }

            public Circle(double radii)//构造函数,切记构造函数没有返回值
            {
                this.Radii = radii;
            }

            public override double GetPerimeter()
            {
                return 2 * Math.PI * this.Radii;
            }

            public override  double GetArea()
            {
                return Math.PI * this.Radii * this.Radii;
            }
        }

        public class Squareness : Shape
        {
            private double _length;
            public double Length
            {
                get { return _length; }
                set { _length = value; }
            }

            private double _weigth;

            public double Weigth
            {
                get { return _weigth; }
                set { _weigth = value; }
            }

            public  Squareness(double length, double weigh)
            {
                this.Weigth = weigh;
                this.Length = length;
            }

            public override double GetArea()
            {
                return this.Length * this.Weigth;
            }

            public override double GetPerimeter()
            {
                return 2 * (this.Weigth + this.Length);
            }
        }


    }
}
