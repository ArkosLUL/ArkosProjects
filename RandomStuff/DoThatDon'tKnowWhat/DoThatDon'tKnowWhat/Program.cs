using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThatDon_tKnowWhat
{
    class Program
    {
        static string Decode(string originalString)
        {
            string stringForModifying1 = originalString.Replace(".", "");

            string stringForModifying2 = Math.Round(Double.Parse(stringForModifying1)).ToString();
            if (Double.Parse(stringForModifying1) < 1025)
            {
                return stringForModifying2;
            }
            else
            {
                return "1";
            }
        }
        static void Main(string[] args)
        {
            Decode("1..02.6");
            Console.ReadLine();
        }
    }
}
