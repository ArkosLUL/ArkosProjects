using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i<=9;i++)
            {
                Console.WriteLine(i +" * "+ n +" = " + i*n);
            }
            Console.ReadKey();
        }
    }
}
