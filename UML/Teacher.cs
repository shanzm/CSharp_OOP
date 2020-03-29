using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Teacher : Person, ILivable, IWorkable
    {
        public double Salary { get; set; }


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

        public void Work()
        {
            Console.WriteLine("教师上班");
        }
    }
}