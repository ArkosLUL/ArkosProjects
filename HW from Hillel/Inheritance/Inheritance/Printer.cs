using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
}
