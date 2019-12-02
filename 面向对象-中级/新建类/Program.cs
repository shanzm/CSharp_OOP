using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 新建类
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------Person类
            Person p0 = new Person();//使用的是无参构造函数
            p0.Name = "志铭";
            p0.Age = 24;
            p0.Gender = "不告诉你";
            p0.Introduct();

            Person p1 = new Person("单志铭", 25);
            p1.Introduct();

            Person p2 = new Person("女");
            p2.Introduct();

            //------------------------------------------------------------------Person2类
            //使用的是默认的无参构造函数
            Person2 p3 = new Person2() { Name = "p3", Age = 25, Gender = "男" };
            p3.Introduct();

            //Person2中的Gender属性的默认值是"女"
            Person2 p4 = new Person2() { Name = "p4", Age = 25 };
            p4.Introduct();

            //只给部分属性初始化
            Person2 p5 = new Person2() { Name = "p5" };//注意哦我们没有设置Age的默认值，也没有给Age初始化，但是C#其整形默认是0
            p5.Introduct();//输出：我是p5,我的年龄是0，我是一个女生，你好！

            //使用的类的快速初始化器
            //注意上面的p3,p4,p5在定义的时候，使用new Person2{……}也是可以的，
            //即：new Person2(){……};和new Person2{……};效果是一样的
            Person2 p6 = new Person2 { Name = "p4", Age = 25, Gender = "男" };
            p6.Introduct();

            //综上我们可以发现其实我们在Person2中并没有定义构造函数，但是我们使用初始化器依旧可是实现初始化


            //------------------------------------------------------------------匿名类型&类型推断
            //类型推断：即隐式类型var ，在编译的时候编译器自动确定数据类型，是强类型。
            //匿名类型：临时需要一个类，但是就只使用这一次，所以没有必要定义一个类，我们可以使用匿名类型，使用new关键字构造
            var p7 = new { Name = "shanzm", Age = 100, Gender = "男" };
            Console.WriteLine($"我是匿名类生成的对象，我的名字是{p7.Name},性别为{p7.Gender },年龄{p7.Age }");

            var ints = new[] { 1, 2, 3, 4 };
            Array.ForEach(ints.ToArray<int>(), n => Console.WriteLine($"我是匿名数组中的：{n}"));


            Console.ReadKey();
        }
    }
}
