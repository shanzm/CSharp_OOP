using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace 新建类
{
    class Person2
    {
        public int Age { get; set; }
        public string Name { get; set; }
        //给属性设置默认值
        public string Gender { get; set; } = "女";

        public void Introduct()
        {
            //C#6.0中using static关键字访问静态类的属性和方法，

            //以前我们调用静态方法使用的是类名.静态方法，现在哦我们只要使用"using static 静态类名;"
            //如：添加using static System.Console;就可以直接调用Console静态类中的方法
            WriteLine($"我是{this.Name},我的年龄是{this.Age},我是一个{this.Gender},你好！");
        }
    }
}