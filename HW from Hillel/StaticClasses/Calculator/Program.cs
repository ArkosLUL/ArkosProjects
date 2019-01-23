using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please, insert two numbers, over them will be held basic mathematical operations ", Environment.NewLine);
                string[] strToParse = Console.ReadLine().Split(' ');
                if (strToParse.Length > 2 || strToParse.Length < 2)
                    break;
                else
                {
                    double a  = double.Parse(strToParse[0]);
                    double b = double.Parse(strToParse[1]);
                    Console.WriteLine("Sum is " + Calculator.Sum(a,b).ToString());
                    Console.WriteLine("Subtraction is " + Calculator.Subtraction(a,b).ToString());
                    Console.WriteLine("Multiply is " + Calculator.Multiply(a,b).ToString());
                    Console.WriteLine("Division is " + Calculator.Division(a,b).ToString());
                    Console.WriteLine("Degree is " + Calculator.Pow(a,b).ToString());
                }
                Console.ReadKey();
                Console.Clear();    
            }
        }
    }
}
