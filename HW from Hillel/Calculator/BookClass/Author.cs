using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class AuthorClass
    {
        private string author;

        public string Author
        {
            get
            {
                return author;
            }
        }

        public AuthorClass(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Author: " + Author, Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
