using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialsForNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true) 
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number >= 10 && number <= 100)
                {
                    Console.WriteLine(number);
                }
                else
                {
                    if (number < 10)
                    {
                        continue;
                    }
                    if(number>100)
                    break;
                }



            } 
            Console.ReadKey();
        }
    }
}
