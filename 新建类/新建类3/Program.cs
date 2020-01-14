using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 面向对象练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket price = new Ticket(100,100);
            price.ShowTicket();
            Console.ReadKey();
        }
    }
}
