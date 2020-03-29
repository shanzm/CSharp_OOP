using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Teacher : Person, ILivable
    {
        public double Salary { get; set; }

        public IEnumerable<Student> students { get; set; }

        public Class @class { get; set; }

        public void Eat()
        {
            Console.WriteLine("老师吃饭");
        }

        public void Gain()
        {
            Console.WriteLine("教师领取薪水");
        }

        public void Sleep()
        {
            Console.WriteLine("老师睡觉");
        }

        public void Teach()
        {
            Console.WriteLine("教学中……");
        }

        public void Call(MobilePhone phone)
        {
            phone.Transfer();
        }
    }
}