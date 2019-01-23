using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanWeCutFromRectangleKSquares
{
    class Program
    {
        static void Main(string[] args)
        { 

            int n, m, i,k;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            i = (n * m) % k;
            if (n*m>=k && k%2==0)
                Console.WriteLine("yes");
            else
                if(n==k || m==k || n*m%k==0 )
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            Console.ReadKey();
        }
    }
}
