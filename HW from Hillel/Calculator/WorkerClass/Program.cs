using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerClass
{
    


    class Program
    {
        static void Main(string[] args)
        {
            Workers workers = new Workers();
            Worker worker1 = new Worker("HerringhtonB", "Aniki", 2000);
            Worker worker2 = new Worker("VanD", "Dungeon Master", 2008);
            Worker worker3 = new Worker("MarkW", "Boss of this gym", 1995);
            workers.InputUserData(worker1);
            workers.InputUserData(worker2);
            workers.InputUserData(worker3);
            workers.Print();
            Console.WriteLine(new string('-', 40));
            workers.Print(true);
            Console.WriteLine(new string('-', 40));
            workers.Print(16);
            Console.ReadKey();
            }
        }
    }

