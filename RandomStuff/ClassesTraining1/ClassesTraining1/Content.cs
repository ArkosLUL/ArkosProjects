using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining1
{
    class Content
    {
        private string contentOfBook;

        public string TitleOfBook { get => contentOfBook; }
        public Content(string contentOfBook)
        {
            this.contentOfBook = contentOfBook;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(contentOfBook);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
