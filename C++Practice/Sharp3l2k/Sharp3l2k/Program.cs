using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharp3l2k
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher tc = new Teacher(new Person("Naruto", "Udzumaki", new DateTime()), "Martial Art", 1997);
            tc.AddGroup(new Group(2000, "PZ", 21), new Group());
            Teacher tc_copy = tc.DeepCopy();
            Console.WriteLine(tc.ToString());
            Console.WriteLine(tc_copy.ToString());
            Console.WriteLine("Введите имя файла");
            string filename = Console.ReadLine();
            tc.Save(filename);
            tc.Load(filename);
            Console.WriteLine(tc.ToString());
            Console.WriteLine("Введите группу в таком формате: [год; название; количество учеников]");
            tc.AddFromConsole();
            tc.Save(filename);
            Teacher.Load(filename, tc);
            Console.WriteLine("А теперь ещё раз");
            tc.AddFromConsole();
            Teacher.Save(filename, tc);
            Console.WriteLine(tc.ToString());
            Console.ReadKey();

        }
    }
}
