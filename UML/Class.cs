using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Class
    {
        public IEnumerable<Student> students { get; set; }
        public IEnumerable<Teacher> teachers { get; set; }
    }
}