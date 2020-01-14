using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 多态_抽象类
{
    /// <summary>
    /// 实现多态使，什么时候使用抽象类，什么时候使用虚方法？
    /// 当你知道，父类的方法有实现时，使用虚方法，见虚方法demo中，分类Person的方法有实现
    /// {Console.WriteLine("我是人类")}，而在这个使用抽象类实现多态的demo中，父类animal
    /// 的方法，你却不知道该实现什么，所以使用一个抽象方法，只为了让各个子类去重写（override）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Anmial a = new Dog();//注意抽象类不能被实例化，所以不能new Anmial();
            a.Doing();///a虽然是dog类型的对象，但是声明时是父类对象，所以调用的是父类Anmial的方法Doing
                      ///但是，父类是抽象类，父类的方法被子类的方法重写了（override），所以显示的
                      ///是调用相应子类的方法
            
            Console.ReadKey();

        }
    }


    /// <summary>
    /// 注意：1.父类中的所有抽象元素（抽象属性，抽象方法）必须在子类中进行重写（override），除非子类也是一个抽象类，就不用重写父类中的抽象成员
    /// 2.抽象类中可以允许有非抽象成员，但是对于父类来说，抽象类不能实例化，所以抽象成员的作用就是继承给子类
    /// 3.非抽象类中不允许有抽象成员,换言之，若需要写抽象成员，则必须写在抽象类中
    /// </summary>
    public abstract class Anmial//通过关键字abstract来定义抽象类，抽象类不能实例化
    {
        public abstract string Name
        {
            set;
            get;
        }
        public abstract void Doing();//抽象方法，没有实现功能，只是为了让子类重写该方法
    }

    public class Cat : Anmial
    {
        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void Doing()
        {
            Console.WriteLine("喵喵");
        }

    }

    public class Dog : Anmial
    {
        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public override void Doing()
        {
            Console.WriteLine("旺旺");
        }

    }
}
