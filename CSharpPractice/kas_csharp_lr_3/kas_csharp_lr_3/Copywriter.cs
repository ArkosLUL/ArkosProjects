using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kas_csharp_lr_3
{
    public class Copywriter: Person, IDateAndCopy
    {
        
        private string nickname;
        private Level rang;
        private int rating;
        private List<Article> listinformationaboutcopywriterarticles;
        private List<Order> orderlist;

        public Person Person
        {
            get
            {
                return (Person)this.DeepCopy();
            }
            set
            {
                Name = value.Name;
                Last_Name = value.Last_Name;
                Birth_Date = value.Birth_Date;
            }
        }
        public Article LastArticle
        {
            get
            {
                if (ListInformationAboutCopywriterArticles.Count > 0)
                    return ListInformationAboutCopywriterArticles.First(x => x.Date_of_publishing == ListInformationAboutCopywriterArticles.Max(y => y.Date_of_publishing));
                else
                    return null;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
        public Level Rang
        {
            get
            {
                return rang;
            }
            set
            {
                rang = value;
            }
        }
        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value <= 0 || value > 5)
                    throw new InvalidOperationException("Rating can't be lower than 0 and higher than 5\n");
                        
            }
        }
        public List<Article> ListInformationAboutCopywriterArticles
        {
            get
            {
                return listinformationaboutcopywriterarticles;
            }
            set
            {
                listinformationaboutcopywriterarticles = value;
            }
        }
        public List<Order> OrderList
        {
            get
            {
                return orderlist;
            }
            set
            {
                orderlist = value;
            }
        }
        public Copywriter(Person person, string nickname, Level rang, int rating):base(person.Name, person.Last_Name, person.Birth_Date)
        {
            
            this.nickname = nickname;
            this.rang = rang;
            this.rating = rating;
            ListInformationAboutCopywriterArticles = new List<Article>();
            OrderList = new List<Order>();
        }

        public Copywriter()
        {
            this.nickname = "blank";
            this.rang = Level.Junior;
            this.rating = -1;
            ListInformationAboutCopywriterArticles = new List<Article>();
            OrderList = new List<Order>();
        }
        public void AddArticles(params Article[] Lists)
        {
            ListInformationAboutCopywriterArticles.AddRange(Lists);
        }
        public void AddOrders(params Order[] Orders)
        {
            OrderList.AddRange(Orders);
        }


        public override string ToString()
        {
            string stringofinformationaboutcopywriterarticles = "";
            foreach (Article p in ListInformationAboutCopywriterArticles)
            {
                stringofinformationaboutcopywriterarticles += "\n***\n" + p.ToString();
            }
            string stringoforders = "";
            foreach (Order p in OrderList)
            {
                stringoforders += "\n***\n" + p.ToString();
            }
            return String.Format("\nAspirant's data: \nName: " +Name+"\nLast name: "+Last_Name+"\nDate of birth: "+ Birth_Date  + "\nNickname: " + nickname + "\nRang: " + rang + "\nRating: " + rating + "\nList of articles: " + stringofinformationaboutcopywriterarticles +"\nList of orders: "+ stringoforders+"\n");
        }
        public override string ToShortString()
        {
            return string.Format("\nAspirant's data: \nName: " + Name + "\nLast name: " + Last_Name + "\nDate of birth: " + Birth_Date+ "\nNickname: " + nickname + "\nRang: " + rang + "\nRating: " + rating + "\nNumber of articles: " + ListInformationAboutCopywriterArticles.Count+"\nNumber of orders: "+ OrderList.Count+ "\n");
        }
        public int average_quantity_of_sings
        {
            get
            {
                int sum = 0;
                int size = ListInformationAboutCopywriterArticles.Count;
                if (size == 0)
                    return 0;
                for (int i = 0; i < size; i++)
                {
                    sum = sum + ListInformationAboutCopywriterArticles[i].Quantity_of_sings;
                }
                sum = sum / size;
                return sum;
            }
        }
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Copywriter obj1, Copywriter obj2)
        {
            return (obj1.ToString() == obj2.ToString());
        }
        public static bool operator !=(Copywriter obj1, Copywriter obj2)
        {
            return (obj1.ToString() != obj2.ToString());
        }
        public override object DeepCopy()
        {
            Copywriter copy = new Copywriter(new Person(this.Name,this.Last_Name, this.Birth_Date), this.Nickname, this.Rang, this.Rating);
            copy.ListInformationAboutCopywriterArticles = new List<Article>();
            foreach (Article p in this.ListInformationAboutCopywriterArticles)
            {
                copy.AddArticles((Article)(p.DeepCopy()));
            }
            copy.OrderList = new List<Order>();
            foreach (Order p in this.OrderList)
            {
                copy.AddOrders((Order)(p.DeepCopy()));
            }
            
            return copy;
        }
        public IEnumerable<object> GetArticleAndOrder()
        {
           // List<Article> articles = new List<Article>();
           // List<Order> orders = new List<Order>();
            foreach (var p in this.ListInformationAboutCopywriterArticles) { yield return p; }
            foreach (var p in this.OrderList) { yield return p; }
        }
        public IEnumerable<Order> GetOrders(int n)
        {
            foreach (Order p in this.OrderList)
            {
                if (p.OrderExecutionTime <= n)
                {
                    yield return p;
                }
            }
        }
    }
    }


