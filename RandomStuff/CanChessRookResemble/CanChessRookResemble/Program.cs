using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_b_c_d_CanChessRookResemble
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowCoordinate1, ColumnCoordinate1, RowCoordinate2, ColumnCoordinate2;
            Console.WriteLine("Enter rook coordinates");
            Console.WriteLine("Enter row № for first coordinate");
            RowCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for first coordinate");
            ColumnCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter row № for second coordinate");
            RowCoordinate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for second coordinate");
            ColumnCoordinate2 = Convert.ToInt32(Console.ReadLine());
            if (RowCoordinate1 == RowCoordinate2 || ColumnCoordinate1 == ColumnCoordinate2)
            {
                Console.WriteLine("Yes, you can resemble");
            }
            else
            {
                Console.WriteLine("No, you can't reseble to this coordinates, better luck next time");
            }
            Console.ReadKey();
        }

    }
}
