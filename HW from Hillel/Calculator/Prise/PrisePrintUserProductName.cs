using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceClass
{
    class PrisePrintUserProductName
    {
        public static void PrintPriseUserProductName(Price[] priseArray)
        {
            Console.WriteLine("Please, enter the name of a product you want to know about");
            string temp = Console.ReadLine();
            for (int i = 0; i < priseArray.Length; i++)
            {
                if(priseArray[i].ProductName == temp)
                {
                    Console.WriteLine(priseArray[i].ToString());
                }
            }
        }
    }
}
