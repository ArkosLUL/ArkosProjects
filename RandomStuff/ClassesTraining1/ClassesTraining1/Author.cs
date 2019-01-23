using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining1
{
    class Author
    {
        private string authorOfBook;

        public string TitleOfBook { get => authorOfBook; }
        public Author(string authorOfBook)
        {
            this.authorOfBook = authorOfBook;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(authorOfBook);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
