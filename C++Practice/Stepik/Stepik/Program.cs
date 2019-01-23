using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter sides length");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nb = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nc = ");
            c = Convert.ToInt32(Console.ReadLine());
            if((a<(b+c))&&(b<(a+c))&&(c<(a+b)))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
