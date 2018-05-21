using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 接口
{
    /// <summary>
    /// 接口是一种规范。
    ///只要一个类继承了一个接口，这个类就必须实现这个接口中所有的成员
    ///为了多态,接口不能被实例化。
    ///也就是说，接口不能new(不能创建对象)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Person();///注意要，接口是不能被实例化的，同样的还有静态类和抽象类不能被实例化
            fly.Fly ();

            Person p=new Person ();
            p.Fly ();
            Console.ReadKey();
        }
    }

    public class Person : IFlyable //alt+shift+f10自动生成需要实现的接口中的成员
    {

        ///这个Fly函数是Person类的自己的函数，但是我还要取实现接口中的Fly函数
        ///但是，因为是同名，编译器自动认为这个是为了实现接口的Fly
        ///但是，我不要这样，那我对接口中的的Fly函数，可以使用显示实现
        public void Fly()
        {
            Console.WriteLine("我是Person类中的自己的方法");
        }

        void IFlyable.Fly()///注意类中成员不写访问修饰符，默认为private，这与接口中默认是PUblic不同
        {
            Console.WriteLine("我是显示实现接口中的成员Fly函数");
        }


        public string Test()
        {
            return null;//继承的接口中的成员，必须把它在子类中实现，哪怕你只是返回null
        }

        string _name;
        public string Name
        {
            set { this._name = value; }
            get { return Name; }
        }
    }

    public interface IFlyable///注意接口的命名一般是I...able
    {
        //接口中的成员不能加“访问修饰符”，接口中的成员访问修饰符默认为public,不能修改。
        //接口中的成员不能有任何实现（“光说不做”，只是定义了一组未实现的成员）。
        //接口中只能有方法、属性、索引器、事件，不能有“字段”和构造函数。
        void Fly();
        string Test();

        string Name//注意，接口中可以属性，但是和普通类中的属性不一样，不要写访问修饰符
        {
            get;//接口中 不能有字段，所有set,和get访问器也不能像普通类中那样有所实现
            set;
        }
    }

}
