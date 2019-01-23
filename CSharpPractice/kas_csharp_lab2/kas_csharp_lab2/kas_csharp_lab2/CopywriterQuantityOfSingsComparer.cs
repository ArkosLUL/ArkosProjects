using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class CopywriterQuantityOfSingsComparer : IComparer<Copywriter>
    {
        public int Compare(Copywriter c1, Copywriter c2)
        {
            if (c1 != null && c2 != null)
            {
                return c1.AverageQuantityOfSings.CompareTo(c2.AverageQuantityOfSings);
            }
            else
            {
                throw new ArgumentException("One of the params doesn't match\n");
            }
        }
    }
}
