using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()), counter = 0;
            while (number!=0)
            {
                number = Convert.ToInt32(Console.ReadLine());
                
                    counter++;
            }

            Console.WriteLine(counter);
            Console.ReadKey();

        }
    }
}
