using System;
using DifferentExtension.Strategy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DifferentStrategyS.Strategy;

namespace DifferentExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecifiedFileContext file = new SpecifiedFileContext(@"D:\test.xml");
            file.Open();
            file.Change();
            file.Save();
            Console.ReadLine();


        }
    }
}
