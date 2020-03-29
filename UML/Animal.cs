using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class Animal : Biology
    {
        public override void Breathe()
        {
            Console.WriteLine("动物呼吸");
        }
    }
}