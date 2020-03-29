using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Student : Person, ILivable
    {
        public string stuNum { get; set; }

        public Teacher teacher { get; set; }

        public Class @class { get; set; }

        public void Eat()
        {
            Console.WriteLine("学生吃饭");
        }

        public void Sleep()
        {
            Console.WriteLine("学生睡觉");
        }

        public void Study()
        {
            Console.WriteLine("学习中……");
        }
    }
}