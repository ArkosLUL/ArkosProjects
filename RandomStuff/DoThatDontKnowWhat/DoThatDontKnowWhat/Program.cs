using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoThatDontKnowWhat
{
    class Program
    {
        static string Decode(string originalString)
        {
            string stringForModifying1 = originalString.Replace(".", "");

            string stringForModifying2 = Math.Ceiling(Double.Parse(stringForModifying1)).ToString();
           if(double.Parse(stringForModifying2)>1010)
            {
                if(double.Parse(stringForModifying2)%2==0)
                {
                    return "2";
                }
                else
                {
                    return "1";
                }
            }
           else
            {
                return stringForModifying2;
            }
               
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Decode("1..02.5"));
            Console.ReadLine();
        }
    }
}
