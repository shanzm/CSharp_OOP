using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket SM = new SuperMarket();
            SM.ShowPros();
            SM.AskBuying();
            Console.ReadKey();
        }
    }
}
