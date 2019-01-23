using System;
namespace ConsoleApplication3
{
    class Program
    {
        public static void Main()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            WriteParabolaMinX(a, b, c);
            Console.ReadKey();

        }
        private static void WriteParabolaMinX(int a, int b, int c)
        {
            double x;
            if (a != 0)
            {
                Console.WriteLine("Impossible");
            }
            else
            {
                try
                {
                   
                    Console.WriteLine(x = (double)-b / (2 * a));
                }
                catch
                {
                    Console.WriteLine("Impossible");
                }
            }
        }
    }
}