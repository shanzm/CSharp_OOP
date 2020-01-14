using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _002_简单工厂和抽象类_计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Operator:");
            string opera = Console.ReadLine();
            Operator p = GetOperator(opera, num1, num2);
            double result = p.Operate();
            Console.WriteLine("result:{0}", result);
            Console.ReadKey();


        }


        /// <summary>
        /// 注意简单工厂的主要模式就是这样，一个抽象父类和几个子类，通过一个函数，使用switch判断创建哪个子类
        /// </summary>
        /// <param name="opera"></param>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static Operator GetOperator(string opera, int num1, int num2)
        {
            Operator op = null;
            switch (opera)
            {
                case "+": op = new Add(num1, num2);
                    break;
                case "-": op = new Sub(num1, num2);
                    break;
                case "*": op = new Mul(num1, num2);
                    break;
                case "/": op = new Div(num1, num2);
                    break;
            }
            return op;
        }
    }




    public abstract class Operator
    {
        public double Num1
        {
            set;
            get;
        }
        public double Num2
        {
            set;
            get;
        }

        public Operator(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;

        }
        public abstract double Operate();
        //注意抽象方法不需要写方法体。
        
    }

    public class Add : Operator
    {
        public Add(double num1, double num2)
            : base(num1, num2)
        {
        }
        public override double Operate()
        {
            return (this.Num1 + this.Num2);

        }
    }


    public class Sub : Operator
    {

        public Sub(double num1, double num2)
            : base(num1, num2)
        {

        }
        public override double Operate()
        {
            return this.Num1 - this.Num2;
        }
    }

    public class Mul : Operator
    {
        public Mul(double num1, double num2)
            : base(num1, num2)
        {

        }
        public override double Operate()
        {
            return this.Num1 * this.Num2;
        }
    }


    public class Div : Operator
    {
        public Div(double num1, double num2)
            : base(num1, num2)
        {
        }


        public override double Operate()
        {
            return this.Num1 / this.Num2;
        }
    }
}
