using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class TitleOfBook
    {
        private string title;

        public string Title
        {
            get
            {
                return title;
            }
        }

        public TitleOfBook(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title: " + Title, Console.ForegroundColor = ConsoleColor.Red);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
