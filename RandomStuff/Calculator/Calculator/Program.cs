using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Calculator
{
    class Program
    {
        public static char[] GetStringFromConsole()
        {
            string stringFromConsole = Console.ReadLine();
            //string[] substring = new string[stringFromConsole.Length];

            //while(stringFromConsole != null)
            //substring =  stringFromConsole.Split(' ');
            char[] stringToParse = new char[stringFromConsole.Length];
            stringToParse = stringFromConsole.ToCharArray();
            return stringToParse;
        }


        public static double GetDouble(char[] stringToParse, ref int index)
        {
            string numberFromString = "";
            while (((int)stringToParse[index] >= 48 && (int)stringToParse[index] <= 57) || (int)stringToParse[index] == 48)
            {
                numberFromString += stringToParse[index].ToString();
                if (index == stringToParse.Length - 1)
                {
                    //index--;
                    break;
                }
                index++;
            }
            return Convert.ToDouble(numberFromString);
        }


        public static double GetFactor(char[] stringToParse, ref int index)
        {
            double numberFromString = GetDouble(stringToParse, ref index);
            while (true)
            {
                char nextToNumber = stringToParse[index];
                if ((int)nextToNumber != 47 && (int)nextToNumber != 42)
                {
                    return numberFromString;
                }
                index++;
                double numberFromStringTemp = GetDouble(stringToParse, ref index);
                if (nextToNumber == '/')
                {
                    numberFromString /= numberFromStringTemp;
                }
                else
                {
                    numberFromString *= numberFromStringTemp;
                }
            }
        }

        public static double GetSummand(char[] stringToParse, int index)
        {
            double factorFromString = GetFactor(stringToParse, ref index);
            while (true)
            {
                char operand = stringToParse[index];
                if ((int)operand != 43 && (int)operand != 45)
                {
                    return factorFromString;
                }
                index++;
                double factorFromStringTemp = GetFactor(stringToParse, ref index);
                if (operand == '+')
                {
                    factorFromString += factorFromStringTemp;
                }
                else
                {
                    factorFromString -= factorFromStringTemp;
                }
            }
        }
        public static double GetEvalExpression(char[] stringToParse)
        {
            return GetSummand(stringToParse, 0);
        }
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    Console.WriteLine(GetEvalExpression(args[1].ToCharArray()).ToString());
                    Console.ReadKey();
                }
                //Console.WriteLine(GetStringFromConsole().ToString());
                Console.WriteLine(GetEvalExpression(GetStringFromConsole()).ToString());
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error happend");
            }
            Console.ReadKey();
        }


    }
}
