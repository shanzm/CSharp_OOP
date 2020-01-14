using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age:");
            string strAge = Console.ReadLine();
            int intAge = Convert.ToInt32(strAge);
            if (intAge >= 18)
            { 
                Console.WriteLine("please surface the page");
            }
            else if (intAge <= 10)
            {
                Console.WriteLine("please go out");
            }
            else
            {
                Console.WriteLine("you need pay for yourself!do you want to contiunt to surfacing");
                Console .WriteLine ("please enter \"yes\"or\"no\" ");
                   string isContinue =Console .ReadLine ();
                if (isContinue=="yes")
                {
                    Console .WriteLine ("lets go");
                }
                else if (isContinue =="no")
                {
                    Console .WriteLine ("please go out");
                }
            }
            Console.ReadKey();
        }
    }
}
