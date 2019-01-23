using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Hello there!");

            DerivedClass1 derived1 = (DerivedClass1)printer;
            derived1.Print("General Kenobi?");

            Console.ReadKey();
        }
    }
}
