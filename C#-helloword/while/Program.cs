using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.WriteLine("enter an number");
                string strVal = Console.ReadLine();
                if (strVal == "quit")
                {
                    return;
                }
                int num = Convert.ToInt32(strVal);
                Console.WriteLine("{0}", num * 2);




                Console.ReadKey();

            }
        }
    }
}
