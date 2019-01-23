using System;
using System.Collections.Generic;
using System.Linq;

namespace AbonentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Abonent[] abonents = new Abonent[] { new Abonent(987654321, "Milos", "Rickardo", "Flexovich", "Brazil", 123456789, 15.75,10.50,new TimeSpan(0,15,0),new TimeSpan(1,0,0)),
                                                 new Abonent(123456789, "Pistoletov", "Alexander","Memovich","Rashka", 987654321, 10.50, 5.50, new TimeSpan().Add(TimeSpan.Zero), new TimeSpan(0,30,0)),
                                                 new Abonent(123456789,"Jmishenko","Valeriy","Al'bertovich", "Jmihstroy", 987654321, 25.00, 50.00, new TimeSpan(0,10,10), new TimeSpan(0,15,0))};
            PrintAbonentsUrbanConv(new DateTime(1,1,1,0,20,0), abonents);
            Console.WriteLine(new string('-',70));
            PrintAbonentsLongDistConv(abonents);
            Console.WriteLine(new string('-', 70));
            List<Abonent> abonentList = new List<Abonent>();
            abonentList.AddRange(abonents);
            abonentList = abonentList.OrderBy(x => x.FirstName).ToList();
            foreach (var abonent in abonentList)
            {
                Console.WriteLine(abonent.ToString());
            }
            Console.ReadLine();
        }
        static void PrintAbonentsUrbanConv(DateTime time, Abonent[] abonents)
        {
            foreach (var abonent in abonents)
            {
                if(abonent.UrbanConversationTime.CompareTo(time)>0)
                {
                    Console.WriteLine(abonent.ToString());
                }
            }
        }

        static void PrintAbonentsLongDistConv(Abonent[] abonents)
        {
            foreach (var abonent in abonents)
            {
                if(abonent.LongDistanceConversationTime.CompareTo(new DateTime())>0)
                { Console.WriteLine(abonent.ToString()); }
            }
        }
    }
}
