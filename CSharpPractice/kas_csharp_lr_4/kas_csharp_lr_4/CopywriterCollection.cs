using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class CopywriterCollection
    {
        private List<Copywriter> ListOfCopywriters;
        public int Avarege()
        {
            int average=0;
            if (ListOfCopywriters.Count == 0)
                return 0;
            for (int i =0;i<ListOfCopywriters.Count;i++)
            {
                average += ListOfCopywriters[i].Rating;
            }
            average = average / ListOfCopywriters.Count;
            return average;

        } 
        public void AddDefaults()
        {
            if(ListOfCopywriters==null)
            {
                 ListOfCopywriters = new List<Copywriter>();
            }
            ListOfCopywriters.Add(new Copywriter());
        }
        public void AddCopywriters(params Copywriter[] array)
        {
            if (ListOfCopywriters == null)
            {
                ListOfCopywriters = new List<Copywriter>();
            }
            ListOfCopywriters.AddRange(array);
        }
        public override string ToString()
        {
            string str = "";
            foreach (Copywriter p in ListOfCopywriters)
            {
                str += p.ToString() + "\n ###### \n";
            }
            return str;
        }
        public virtual string ToShortString()
        {
            string str = "";
            foreach(Copywriter p in ListOfCopywriters)
            {
                str += p.ToShortString();
            }
            return str;
        }
        public void SortByLastName()
        {
            ListOfCopywriters.Sort();
        }
        public void SortByBirthDate()
        {
            ListOfCopywriters.Sort(new Copywriter());
        }
        public void SortByAveregeQuantityOfSings()
        {
            ListOfCopywriters.Sort(new CopywriterQuantityOfSingsComparer());
        }
    }
}
