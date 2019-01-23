using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticMeanOfTheNumbersOnTheInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            int counter = 0;
            while(a != b+1)
            {
                if(a%3!=0)
                {
                    a++;
                    
                }
                else
                {
                    sum += a;
                    counter++;
                    
                    a++;
                }
            }
            sum /= counter;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
