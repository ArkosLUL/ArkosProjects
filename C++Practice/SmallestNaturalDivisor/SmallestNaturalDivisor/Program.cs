using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNaturalDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine()), divisor=2;
            if(number>=2)
            {
                while(number%divisor!=0)
                {
                    divisor++;
                }
            }
            Console.WriteLine(divisor);
            Console.ReadKey();
        }
    }
}
