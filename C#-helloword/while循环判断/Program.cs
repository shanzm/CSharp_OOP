using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 循环判断
{
    class Program
    {
        static void Main(string[] args)     
        {

            int max = 0;
            while (true)
            {
                Console.WriteLine("please enter a num(When you want to stop by enter\'end\')");
                
                string strval = Console.ReadLine();
               
                if (strval !="end")
                {
                    int num = Convert.ToInt32(strval);
                    if (num > max)
                    {
                        max = num;
                    }
                }
                else
                {
                     Console.WriteLine("max={0}", max);
                    Console.ReadKey();
                    return;
                }
            }

        }
    }
}
