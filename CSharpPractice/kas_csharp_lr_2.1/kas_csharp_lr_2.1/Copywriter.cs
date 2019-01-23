using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kas_csharp_lr_2._1
{
    public class Copywriter
    {
        private Person pPerson;
        private string nickname;
        private Level rang;
        private int rating;
        private Article[] list;

        public Copywriter(Person pperson, string nickname, Level rang, int rating)
        {
            pPerson = pperson;
            this.nickname = nickname;
            this.rang = rang;
            this.rating = rating;
            if(list == null)
            list = new Article[0];
        }

        public Copywriter()
        {
            pPerson = new Person();
            
            this.nickname = "blank";
            this.rang = Level.Junior;
            this.rating = -1;
            this.list = new Article[3];
            for (int i=0; i<3; i++)
            {
                list[i] = new Article("lr1", 50,new DateTime(2018,05,24)); 
            }
        }

        public Person PPerson
        {
            get
            {
                return pPerson;
                
            }
            set
            {
                pPerson = value;
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
                rating = value;
            }
        }
        public Article[] List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
            
        }
        public void AddArticles(params Article[] Lists)
        {
           
            int k = List.Length + Lists.Length;
            Article[] a2 = new Article[k];
            for (int i = 0; i < List.Length; i++)
                a2[i] = List[i];
            int b = List.Length;
            for (int i = 0; i < Lists.Length; i++)
                a2[b++] = new Article(Lists[i].Article_name, Lists[i].Quantity_of_sings, Lists[i].Date_of_publishing);
            List = a2;
            //Array.Resize(ref list, list.Length + Lists.Length);
            //int k= list.Length;
            //for (int i = 0; i <Lists.Length;i++ )
            //{

            //    list[i+k] = Lists[i];
            //}     
        }
        public override string ToString()
        {
            string str="";
            int i;
            for (i = 0; i < list.Length; i++)
                str = str + list[i].ToString();
            return String.Format("Aspirant's data: "+pPerson + "\nNickname: " + nickname + "\nRang: " + rang +"\nRating: "+ rating + "\nList of articles: " + str+"\n");
        }
        public virtual string ToShortString()
        { 
            return string.Format("Aspirant's data " + pPerson + "\nNickname: " + nickname + "\nRang: " + rang + "\nRating: " + rating + "\nNumber of articles=" +list.Length +"\n");
        }
       public int average_quantity_of_sings
        {
            get
            {
                int sum=0;
                int size = List.Length;
                if (size == 0)
                    return 0;
                    for(int i = 0; i < List.Length;i++)
                {
                    sum = sum + List[i].Quantity_of_sings;
                }
                sum = sum / List.Length;
                return sum;
            }
        }
    }
 }
    
