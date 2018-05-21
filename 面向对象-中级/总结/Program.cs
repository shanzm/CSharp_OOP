using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 总结
{
    class Program
    {
       
///实现多态有三种方法——虚方法，抽象类，接口
///那么具体怎么选择呢
///当提供给你的各个类中可以抽象出一个父类，并且父类可以写出各个子类共有的一个方法，
///但是你因为各个子类的这个方法实现内容是不同的，所以不知道怎么在父类中写这个方法，
///此时选用抽象类的方法，实现多态。
///反之你可以写出父类中的这个共同的方法，且要求你创建父类的对象则用虚方法
///当给你的这几个类，你找不到一个可以抽象出来的父类，但是他们都有一个共同的行为（比如说鸟类，和飞机，都可以飞，但是你找不到父类）
///此时，你就可以选用接口，来实现多态

        ///练习：真鸭子会游泳，橡皮鸭子会游泳，木头鸭子不会游泳，用多态实现
        ///我们可以分析一下，我们可以抽象出一个父类，但是虚方法和抽象类，你没法用，因为木头鸭子-不会游泳，所以你写不出来一个共同方法
        static void Main(string[] args)
        {
            Iswiming  rd = new RealDuck();
            rd.Swim();

            MuDuck  md = new MuDuck();
            md.Say();

           Iswiming  xd = new XPDuck();
            xd.Swim();

            
            Console.ReadKey();

        }

        public class RealDuck:Iswiming
        {
            public void Swim()
            {
                Console.WriteLine("我是真的鸭子，我靠脚掌游泳");
            }
        }

        public class MuDuck
        {
            public void Say()
            {
                Console.WriteLine("我是木头鸭子，不会游泳");
            }
        }

        public class XPDuck:Iswiming
        {

            public void Swim()
            {
                Console.WriteLine("我是橡皮鸭子，我是自动漂浮游泳");
            }
        }


        public interface Iswiming
        {
            void Swim();
        }
    }
}
