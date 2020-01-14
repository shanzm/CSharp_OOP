using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo
{

    enum oriention : int
    {
        north = 1,
        south = 2,
        west = 3,
        east = 4,
    }
    struct myroute
    {
        public oriention myoriention;
        public double mydistance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            myroute route;
            int mydirection;
            Console.WriteLine("1)north\n2)south\n3)east\n4)west\n");
          
            do
            {
                Console.WriteLine(" please select a direction");
                mydirection = Convert.ToInt32(Console.ReadLine());
            }
            while ((mydirection > 4) && (mydirection < 1));

            route.myoriention = (oriention)mydirection;
            Console.WriteLine("enter myroute ditance");
            route.mydistance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("myroute specifies a direction of{0}"
                + " a distance of{1}", route.myoriention, route.mydistance);
            Console.ReadKey();





        }
    }
}
