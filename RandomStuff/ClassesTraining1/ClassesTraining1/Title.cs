using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining1
{
    class Title
    {
        private string titleOfBook;

        public string TitleOfBook { get => titleOfBook; }
        public Title(string titleOfBook)
        {
            this.titleOfBook = titleOfBook;
        } 
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(titleOfBook);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
