using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanElephantResemble
{
    class Program
    {
        static void Main(string[] args)
        {
            int RowCoordinate1, ColumnCoordinate1, RowCoordinate2, ColumnCoordinate2;
            Console.WriteLine("Enter start coordinates for an elephant");
            Console.WriteLine("Enter row № ");
            RowCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № ");
            ColumnCoordinate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter end coordinates for an elephant");
            Console.WriteLine("Enter row № ");
            RowCoordinate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter column № ");
            ColumnCoordinate2 = Convert.ToInt32(Console.ReadLine());
            if(RowCoordinate1>=1&&RowCoordinate1<=8&&ColumnCoordinate1>=1&&ColumnCoordinate1<=8&&RowCoordinate2>=1&&RowCoordinate2<=8&&ColumnCoordinate2>=1&&ColumnCoordinate2<=8)
            {
               
                    if (Math.Abs(ColumnCoordinate1 - ColumnCoordinate2) == Math.Abs(RowCoordinate1 - RowCoordinate2))
                    {
                        Console.WriteLine("Yes, Elephant can resemble to this coordinates");
                    }
                    else
                    {
                        Console.WriteLine("No, elephant cannot resemble, better luck next time");
                    }
                }
               
            
            else
            {
                Console.WriteLine("You entered wrong data, please try again");
            }
            Console.ReadKey();
        }
    }
}
