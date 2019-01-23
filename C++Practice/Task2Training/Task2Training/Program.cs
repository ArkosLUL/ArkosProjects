using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Training
{
    class Program
    {
        static void Main(string[] args)
        {
            Orders orders = new Orders();
            Order order1 = new Order(123456789, 987654321, 1200);
            Order order2 = new Order(987654321, 123456789, 5200);
            Order order3 = new Order(986654321, 723456789, 300);
            orders.InputUserData(order1);
            orders.InputUserData(order2);
            orders.InputUserData(order3);
            orders.Print();
            Console.WriteLine(new string('-', 40));
            orders.Print(isSorted: true);
            Console.WriteLine(new string('-', 40));
            orders.Print(1200);
            Console.ReadLine();
        }
    }
}
