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
            Person szm = new Person();
            szm.Name = "志铭";
            szm.Age = 24;
            szm.Gender = "不告诉你";

            szm.Introduct();
            string a = "小米";
            Console.WriteLine($"hello {a}");
            Console.ReadKey();
            
        }
    }
}
