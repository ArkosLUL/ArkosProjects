using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BookClass book = new BookClass("Hobbit", "Tolkien", "Tuda and obratno");
            
           
            book.Show();
            Console.ReadLine();

        }
    }
}
