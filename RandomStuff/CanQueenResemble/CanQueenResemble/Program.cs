using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanQueenResemble
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowCoordinates1, ColumnCoordinates1, RowCoordinates2, ColumnCoordinates2;
            Console.WriteLine("Enter start coordinates for the Queen");
            Console.WriteLine("Enter row № for first coordinate");
            RowCoordinates1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter row № for first coordinate");
            ColumnCoordinates1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end coordinates for the Queen");
            Console.WriteLine("Enter row № for first coordinate");
            RowCoordinates2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter row № for first coordinate");
            ColumnCoordinates2 = Convert.ToInt32(Console.ReadLine());
            if((ColumnCoordinates1==ColumnCoordinates2)||(RowCoordinates1==RowCoordinates2)||(Math.Abs(ColumnCoordinates1-ColumnCoordinates2)==Math.Abs(RowCoordinates2-RowCoordinates1)))
            {
                Console.WriteLine("Yes, the Queen can resemble to this coordinates");
            }
            else
            {
                Console.WriteLine("No, the Queen cannot resemble to this coordinates");
            }
            Console.ReadKey();
        }
    }
}
