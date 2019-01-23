using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanChessKingResemble
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowCoordinate1, ColumnCoordinate1, RowCoordinate2, ColumnCoordinate2;
            Console.WriteLine("Enter start coordinates for the King");
            Console.WriteLine("Enter row № for first coordinate");
            RowCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for first coordinate");
            ColumnCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end coordinates for the King");
            Console.WriteLine("Enter row № for second coordinate");
            RowCoordinate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for second coordinate");
            ColumnCoordinate2 = Convert.ToInt32(Console.ReadLine());
            if ((ColumnCoordinate1 > 0 && ColumnCoordinate1 < 9) || (ColumnCoordinate2 > 0 && ColumnCoordinate2 < 9) || (RowCoordinate1 > 0 && RowCoordinate1 < 9) || (RowCoordinate2 > 0 && RowCoordinate2 < 9))
                {
                if (Math.Abs(ColumnCoordinate2 - ColumnCoordinate1) > 1  || Math.Abs(RowCoordinate2 - RowCoordinate1) > 1)
                {
                    Console.WriteLine("No, King cannot resemble to rhis coordinates, better luck next time");
                }
                else
                {
                    Console.WriteLine("Yes, King can resemble");
                }
            }
            else
            {
                Console.WriteLine("Coordinate of range");
            }
            Console.ReadKey();

        }
    }
}
