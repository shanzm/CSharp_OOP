using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student zhangsan = new Student();//对象实例化
            /*在研究了构造函数后，我们不禁会想，一开始，我们并没有编构造函数
             * 但是我们对象实例化时，也是使用了student（）呀，其实这是我们在
             * 创建类的时候默认的带的构建函数，只是这个默认的构建函数，他没有参数
             * 所以这个默认的构建函数也没有对属性进行任何的操作。*/
            



            //对象初始化，给对象的每一个属性进行赋值
            //zhangsan.Name = "张三";
            //zhangsan.Gender = '男';
            //zhangsan.Age = 25;
            //zhangsan.Chinses = 100;
            //zhangsan.Math = 100;
            //zhangsan.English = 100;
            //zhangsan.SayHello();
            //zhangsan.ShowScore();
            //Console.ReadKey();

            //使用构造函数来进行初始化对象；
            Student zhangsan = new Student("张三", '男', 23, 100, 100, 100);
            zhangsan.SayHello();
            zhangsan.ShowScore();
            //同样也可以在程序中，直接调用类的属性
            Console.WriteLine(zhangsan.Math);

            Student lisi = new Student("李四", '男', 24, 90, 90, 100);
            lisi.SayHello();
            lisi.ShowScore();
            Console.ReadKey();

            Student wangwu = new Student("王五", 100);
            wangwu.ShowScore();
            Console.ReadKey();

        }
    }
}
