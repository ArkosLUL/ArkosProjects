using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kas_csharp_lr_4
{
    public class Article
    {
        public string Article_name
        { get; set; }
        public int Quantity_of_sings
        { get; set; }
        public DateTime Date_of_publishing
        { get; set; }
        public Article(string article_name, int quantity_of_sings, DateTime date_of_publishing)
        {
            this.Article_name = article_name;
            this.Quantity_of_sings = quantity_of_sings;
            this.Date_of_publishing = date_of_publishing;
        }
        public Article()
        {
            this.Article_name = "blank";
            this.Quantity_of_sings = 0;
            this.Date_of_publishing = DateTime.Today;
        }
        public override string ToString()
        {
            return String.Format("\nArticle name: " + Article_name + "\nQuantity of sings in article: " + Quantity_of_sings + "\nDate of article publishing: " + Date_of_publishing + "\n");
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Article obj1, Article obj2)
        {
            return (obj1.ToString() == obj2.ToString());
        }
        public static bool operator !=(Article obj1, Article obj2)
        {
            return (obj1.ToString() != obj2.ToString());
        }
        public object DeepCopy()
        {
            object article = new Article();
            ((Article)article).Article_name = this.Article_name;
            ((Article)article).Quantity_of_sings = this.Quantity_of_sings;
            ((Article)article).Date_of_publishing = this.Date_of_publishing;
            return article;
        }
    }


}

