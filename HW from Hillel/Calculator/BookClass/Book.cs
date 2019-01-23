using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClass
{
    class BookClass
    {
        TitleOfBook titleOfBook = null;
        AuthorClass authorOfBook = null;
        ContentOfBook contentOfBook = null;


        public BookClass(string title, string author, string content)
        {
            Initializiar(title, author, content);
        }

        public void Initializiar(string title, string author, string content)
        {
            this.titleOfBook = new TitleOfBook(title);
            this.authorOfBook = new AuthorClass(author);
            this.contentOfBook = new ContentOfBook(content);
        }

        public void Show()
        {
            titleOfBook.Show();
            authorOfBook.Show();
            contentOfBook.Show();
        }
    }
}
