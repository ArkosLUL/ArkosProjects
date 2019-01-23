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
            CopywriterCollection collection1 = new CopywriterCollection("Collection 1");
            CopywriterCollection collection2 = new CopywriterCollection("Collection 2");
            Journal journal1 = new Journal();
            Journal journal2 = new Journal();
            collection1.CopywriterCountChanged += journal1.CopywriterCountChanged;
            collection1.CopywriterReferenceChanged += journal1.CopywriterReferenceChanged;
            collection1.CopywriterReferenceChanged += journal2.CopywriterReferenceChanged;
            collection2.CopywriterReferenceChanged += journal2.CopywriterReferenceChanged;
            collection1.AddDefaults();
            collection1.AddDefaults();
            collection1.AddDefaults();
            collection1.Remove(1);
            collection1[0].Nickname = "Arkos";
            collection1[0] = new Copywriter(new Person(), "Ortem", new Level(), 1000);
            collection1.AddCopywriters(new Copywriter());
            collection2.AddDefaults();
            collection2.AddDefaults();
            collection2.Remove(0);
            collection2[0].Nickname = "ArkosLUL";
            collection2.AddCopywriters(new Copywriter(new Person(), "ArkosOmegaLUL", new Level(), 150));
            collection2[1] = new Copywriter(new Person(), "ArkosLUL", new Level(), 200);
            Console.WriteLine(journal1.ToString());
            Console.WriteLine(journal2.ToString());
            Console.ReadKey();
            
        }
    }
}
