using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СolorOfACheckerboardSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int ColumnCoordinate1, RowCoordinate1, ColumnCoordinate2, RowCoordinate2;
            ColumnCoordinate1 = Convert.ToInt32(Console.ReadLine());
            ColumnCoordinate2 = Convert.ToInt32(Console.ReadLine());
            RowCoordinate1 = Convert.ToInt32(Console.ReadLine());
            RowCoordinate2 = Convert.ToInt32(Console.ReadLine());
            if ((Math.Abs(ColumnCoordinate1-ColumnCoordinate2)%2== 0 && Math.Abs(RowCoordinate1 - RowCoordinate2) % 2 == 0) ||
                (Math.Abs(ColumnCoordinate1 - ColumnCoordinate2) % 2 != 0 && Math.Abs(RowCoordinate1 - RowCoordinate2) % 2 != 0) )
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
