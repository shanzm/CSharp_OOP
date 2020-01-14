using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string []friendNames={"a","b","c"};
            Console .WriteLine ("here is my{0} friends",friendNames .Length );
            //foreach (string friendName in friendNames)
            //{ Console.WriteLine(friendName); }
            for (i = 0; i < friendNames.Length; i++)
            {
                Console.WriteLine(friendNames[i]);
            }

            Console.ReadKey();

        }
    }
}
