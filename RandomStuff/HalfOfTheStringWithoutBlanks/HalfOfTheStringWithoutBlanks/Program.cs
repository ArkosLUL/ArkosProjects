using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfOfTheStringWithoutBlanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));
            Console.ReadKey();
        }
        public static string GetLastHalf(string text)
        {
            string str = text.Substring(text.Length / 2);
            
            return str.Replace(" ", ""); ;

        }
    }
   
}
