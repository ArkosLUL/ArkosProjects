using System;

namespace TimeRep
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            while (true)
            {
                try
                {
                    Console.WriteLine("Please, input time you want to change");
                    string strFromUser = Console.ReadLine();
                    string[] buf = strFromUser.Split(",", StringSplitOptions.RemoveEmptyEntries);
                    if (buf.Length < 3 || buf.Length > 3)
                        throw new FormatException("Input was in wrong format");
                    time.ChangeTime(int.Parse(buf[0]), int.Parse(buf[1]), int.Parse(buf[2]));
                    Console.WriteLine(time.ToString());
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
