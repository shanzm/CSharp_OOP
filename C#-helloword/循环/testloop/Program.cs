using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //while (i <= 10)
            //{
            //    if (i ==6)
            //        break ;
            //    Console .WriteLine ("{0}",i++);
            //    Console .ReadKey();
            //}

            //此段代码按一次回车，出一个数，一直到10
            //for (i = 1; i <= 10; ++i)
            //{
            //    Console.WriteLine("{0}", i);
            //    Console.ReadKey();
            //}

            //此段代码直接输出1到10，为什么尼因为你的Console.ReadKey()写在了
            //循环体之后
            do
            {
                Console.WriteLine("{0}", i++);
            } while (i <= 10);
            Console.ReadKey();
        }
    }
}
