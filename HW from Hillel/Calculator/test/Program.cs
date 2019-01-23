using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "2 + 2 * 3";
            string[] substrings = str.Split(' ');
            char[] buf = new char[substrings.Length];
            for (int i  = 0; i  < substrings.Length; i ++)
            {
                buf = substrings[i];
            }
            for (int i = 0; i < buf.Length; i++)
            {
                Console.WriteLine(buf[i]);
            }
        }
    }
}
