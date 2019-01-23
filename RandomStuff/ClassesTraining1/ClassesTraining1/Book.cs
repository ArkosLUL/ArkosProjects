using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTraining1
{
    class Book
    {
       private Title titleOfBook = null;
       private Author authorOfBook = null;
       private Content contentOfBook = null;
        public Book(string titleOfBook, string authorOfBook, string contentOfBook)
        {
            Inicializar(titleOfBook, authorOfBook, contentOfBook);
        }  
        private void Inicializar(string titleOfBook, string authorOfBook, string contentOfBook)
        {
            this.titleOfBook = new Title(titleOfBook);
            this.authorOfBook = new Author(authorOfBook);
            this.contentOfBook = new Content(contentOfBook);
        }
        public void ShowBook()
        {
            titleOfBook.Show();
            authorOfBook.Show();
            contentOfBook.Show();
        }

    }
}
