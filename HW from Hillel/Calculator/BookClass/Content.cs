using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class ContentOfBook
    {
        private string content;

        public string Content
        {
            get
            {
                return content;
            }
        }

        public ContentOfBook(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Content: " + Content, Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
