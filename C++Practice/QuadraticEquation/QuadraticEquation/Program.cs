using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static double SquareDiscriminantRoot(int a, int b, int c)
        {
            double discriminant = b*b - 4*a*c;

            return Math.Sqrt(discriminant);


        }
        static string Root(int a, int b, int c)
        {
            
            if(SquareDiscriminantRoot(a, b, c)< 0)
            {
                return "Find a root is impossible";

            }
            else
            {
                if (SquareDiscriminantRoot(a, b, c) == 0)
                {
                    return (-b / (2 * a)).ToString();
                }
                else
                {
                    return String.Format(((-b + SquareDiscriminantRoot(a, b, c) )/ (2 * a)).ToString() + ((-b - SquareDiscriminantRoot(a, b, c)) / (2 * a)).ToString());
                }

            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Root(a,b,c));
            Console.ReadKey(); 

        }
    }
}
