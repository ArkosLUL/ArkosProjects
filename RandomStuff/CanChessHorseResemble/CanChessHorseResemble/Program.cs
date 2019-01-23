using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanChessHorseResemble
{
    class Program
    {
        static void Main(string[] args)
        {
            int ColumnCoordinates1, RowCoordinates1, ColumnCoordinates2, RowCoordinates2;
            Console.WriteLine("Enter start coordinates for the Chess Horse");
            Console.WriteLine("Enter row № for first coordinate");
            ColumnCoordinates1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for first coordinate");
            RowCoordinates1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end coordinates for the Chess Horse");
            Console.WriteLine("Enter row № for first coordinate");
            ColumnCoordinates2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № for first coordinate");
            RowCoordinates2 = Convert.ToInt32(Console.ReadLine());
            if((Math.Abs(ColumnCoordinates1-ColumnCoordinates2)==2)&&(Math.Abs(RowCoordinates1-RowCoordinates2)==1)|| (Math.Abs(ColumnCoordinates1 - ColumnCoordinates2) == 1) && (Math.Abs(RowCoordinates1 - RowCoordinates2) == 2))
                {
                    Console.WriteLine("Yes, Chess Horse can resemble to this coordinates");
                }
            else
               {
                    Console.WriteLine("No, Chess Horse cannot resemble to this coordinates");
               }
            Console.ReadKey();
        }
    }
}
