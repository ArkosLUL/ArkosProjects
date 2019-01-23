using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CopywriterCollection<string> dictionary1 = new CopywriterCollection<string>("First collection");
            CopywriterCollection<string> dictionary2 = new CopywriterCollection<string>("Second collection");
            Journal<string> journal = new Journal<string>();
            dictionary1.CopywritersChanged += journal.CopywritersChanged;
            dictionary2.CopywritersChanged += journal.CopywritersChanged;
            Copywriter Mark = new Copywriter(new Person("Mark", "Wolf", new DateTime(1967, 01, 01)), "Boss of this gym", Level.MidLevel, 4);
            Copywriter Van = new Copywriter(new Person("Van", "Darkholme", new DateTime(1972, 10, 24)), "Dungeon Master", (Level)2, 3);
            Copywriter Aniki = new Copywriter(new Person("Billy", "Herrington", new DateTime(1969, 07, 14)), "Big Brother", (Level)2, 1);
            Copywriter Arkos = new Copywriter(new Person("Artem", "Kosogov", new DateTime(2000, 05, 26)), "Arkos", (Level)2, 2);
            dictionary1.AddCopywritersToDictionary("111", Arkos);
            dictionary1.AddCopywritersToDictionary("112", Aniki);
            dictionary1.AddCopywritersToDictionary("113", Van);
            dictionary2.AddCopywritersToDictionary("111", Mark);
            dictionary1["112"].Nickname = "Aniki";
            dictionary1["111"].Rating = 3;
            dictionary1.Remove(Arkos);
            Arkos.Rating = 4;
            Console.WriteLine(journal.ToString());
            List<Copywriter> sortedList = dictionary1.GetSortedListOfCopywriters();
            foreach (var cw in sortedList)
            {
                Console.WriteLine(cw.ToString());
            }
            Console.ReadKey();
        }
    }
}
