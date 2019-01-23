using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposite
{
    class Program
    {
        static double Calculate(string userInput)
        {
            string[] tempString = userInput.Split(' ');
            double startSum =  Convert.ToDouble(tempString[0]);
            double interestRate = Convert.ToDouble(tempString[1]);
            int termOfDepositeInMonth = Convert.ToInt32(tempString[2]);
            double sumAtTheEndOfDeposite = startSum;
            for ( int i = 0; i<termOfDepositeInMonth; i++)
            {
                sumAtTheEndOfDeposite += sumAtTheEndOfDeposite * interestRate / 1200;
            }
            return sumAtTheEndOfDeposite;
        }

        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            

            
            Console.WriteLine(Calculate(userInput));
            Console.ReadKey();
        }
    }
}
