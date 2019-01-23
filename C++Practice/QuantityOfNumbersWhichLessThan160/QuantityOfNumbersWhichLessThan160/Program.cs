using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantityOfNumbersWhichLessThan160
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, counter=0;
            for(int i = 0; i<20;i++)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number>160)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
