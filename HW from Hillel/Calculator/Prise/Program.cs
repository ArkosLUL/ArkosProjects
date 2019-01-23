using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceClass
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Prices prices = new Prices();
            Price price1 = new Price("Sausages delicate", "ATB", 17.90);
            Price price2 = new Price("Pani hutoryanka", "Varus", 20); 
            Price price3 = new Price("Sadochok", "ATB", 13);
            Price price4 = new Price("Devstvennost' Pavluka", "Obshaga", 0.0001);
            prices.InputUserData(price1);
            prices.InputUserData(price2);
            prices.InputUserData(price3);
            prices.InputUserData(price4);
            prices.Print();
            Console.WriteLine(new string('-', 40));
            prices.Print(isSorted: true);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Enter product name to search");
            string str = Console.ReadLine();
            prices.Print(str);
            Console.ReadLine();

        }
    }
}
