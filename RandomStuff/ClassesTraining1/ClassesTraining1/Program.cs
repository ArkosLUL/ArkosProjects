using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Преступление и наказание","Достоевский","bla-bla-bla");
            book.ShowBook();
            Console.ReadLine();
        }
    }
}
