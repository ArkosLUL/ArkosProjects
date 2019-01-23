using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSymbolPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Task.CheckPairs(s, '(', ')'));
            Console.ReadKey();
        }
    }
    class Task
    {
        public static string CheckPairs(string s, char a, char b)
        {
            int temp1 = 0, temp2 = 0,  counter = 0;


            // for (int m = 0; m < s.Length; m++)
            // {
            for (int i = temp1; i < s.Length; i++)
            {
                if (s[i] == a)
                {
                    counter++;
                    temp1 = i;
                }
            }
                for (int j = temp2; j < s.Length; j++)
                    {
                        if (s[j] == b)
                        {
                            counter--;
                            temp2 = j;
                        }
                    }
                
           // }
              
            
            if (counter != 0)
            {
                return "Найдены ошибки";
            }
            else
            {
                return "Все в порядке";
            }
        }
    }   
}
