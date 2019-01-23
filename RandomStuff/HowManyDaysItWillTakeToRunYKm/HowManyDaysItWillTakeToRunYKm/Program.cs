using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyDaysItWillTakeToRunYKm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double x = Convert.ToInt32(Console.ReadLine());
            double y = Convert.ToInt32(Console.ReadLine());
            int dayscounter;
            for( dayscounter = 1; x<y; x *= 1.1, dayscounter++)
            {
                
            }
            Console.WriteLine(dayscounter);
            Console.ReadKey();
        }
    }
}
