using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 多态
{
    /// <summary>
    /// 多态是指使一种对象具有多种形态（类型）
    /// 多态实现的方法有三种：1.虚方法，1.抽象类，3.接口
    /// </summary>

    //#region
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Chinese cn1 = new Chinese("张三");
    //        Chinese cn2 = new Chinese("李四");
    //        Japanese ja = new Japanese("半泽值树");
    //        Korea ko = new Korea("思密达");
    //        American am = new American("川普");

    //        Person[] person = new Person[5] { cn1, cn2, ja, ko, am };
    //        foreach (Person item in person)
    //        {

    //            ///此处 你若是直接写item.SayHello();则会全部打印“我是人类”，因为在
    //            ///person类型数组中，所有元素（对象）表现的都是父类类型，都是调用的父类方法
    //            ///有么有什么方法使得父类类型的数组中的每一个子类对象都各自调用自己的方法呢
    //            ///那便是多态
    //            if (item is Chinese)
    //            {
    //                ((Chinese)item).SayHello();
    //            }

    //            else if (item is Japanese )
    //            {
    //                ((Japanese)item).SayHello();
    //            }

    //            else if (item is Korea)
    //            {
    //                ((Korea)item).SayHello();
    //            }

    //            else if (item is American )
    //            {
    //                ((American)item).SayHello();
    //            }
    //        }
    //        Console.ReadKey();
    //    }
    //}

    //public class Person
    //{
    //    private string _name;

    //    public string Name
    //    {
    //        set { _name = value; }
    //        get { return _name; }
    //    }

    //    public Person(string name)
    //    {
    //        this.Name = name;
    //    }

    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是人类");
    //    }
    //}


    //public class Chinese : Person
    //{
    //    public Chinese(string name)
    //        : base(name)
    //    {

    //    }
    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是{0}", this.Name);
    //    }
    //}

    //public class Japanese : Person
    //{
    //    public Japanese(string name)
    //        : base(name)
    //    {

    //    }
    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是{0}", this.Name);
    //    }
    //}

    //public class Korea : Person
    //{
    //    public Korea(string name)
    //        : base(name)
    //    {

    //    }
    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是{0}", this.Name);
    //    }
    //}

    //public class American : Person
    //{
    //    public American(string name)
    //        : base(name)
    //    {

    //    }
    //    public void SayHello()
    //    {
    //        Console.WriteLine("我是{0}", this.Name);
    //    }
    //}
    //#endregion
    #region
    class Program
    {
        static void Main(string[] args)
        {
            Chinese cn1 = new Chinese("张三");
            Chinese cn2 = new Chinese("李四");
            Japanese ja = new Japanese("半泽值树");
            Korea ko = new Korea("思密达");
            American am = new American("川普");
            Person p = new Person();//用虚方法实现多态主要原因就是我们需要实例化父类

            Person[] person = new Person[6] { cn1, cn2, ja, ko, am ,p};
            foreach (Person item in person)
            {
                item.SayHello ();
            }
            Console.ReadKey();
        }
    }

    public class Person
    {
        private string _name;

        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        public Person(string name)
        {
            this.Name = name;
        }

        public Person()
        {
        }

        public virtual  void SayHello()///在此处父类的方法声明处添加关键字virtual（虚拟的）
        {
            Console.WriteLine("我是人类");
        }
    }


    public class Chinese : Person
    {
        public Chinese(string name)
            : base(name)
        {

        }
        public override void SayHello()///在每一个子类的方法处添加一个关键字override（覆盖重写）
        {
            Console.WriteLine("我是{0}", this.Name);
        }
    }

    public class Japanese : Person
    {
        public Japanese(string name)
            : base(name)
        {

        }
        public override void SayHello()///在每一个子类的方法处添加一个关键字override（覆盖重写）
        {
            Console.WriteLine("我是{0}", this.Name);
        }
    }

    public class Korea : Person
    {
        public Korea(string name)
            : base(name)
        {

        }
        public override void SayHello()///在每一个子类的方法处添加一个关键字override（覆盖重写）
        {
            Console.WriteLine("我是{0}", this.Name);
        }
    }

    public class American : Person
    {
        public American(string name)
            : base(name)
        {

        }
        public override void SayHello()///在每一个子类的方法处添加一个关键字override（覆盖重写）
        {
            Console.WriteLine("我是{0}", this.Name);
        }
    }
    #endregion
}
