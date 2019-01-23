using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    
    class CopywriterCollection
    {
        public delegate void CopywriterListHandler(object source, CopywriterListHandlerEventArgs args);
        public event CopywriterListHandler CopywriterCountChanged;
        public event CopywriterListHandler CopywriterReferenceChanged;
        public string CopywriterCollectionName { get; set; }
        private List<Copywriter> ListOfCopywriters;
        public CopywriterCollection()
        {
            CopywriterCollectionName = "Default collection name";
        }
        public CopywriterCollection(string copywriterCollectionName)
            {
                CopywriterCollectionName = copywriterCollectionName;
            } 
        public int Average()
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
            Copywriter copywriter = new Copywriter();
            
            ListOfCopywriters.Add(copywriter);
            
            if (CopywriterCountChanged != null)
            {
                CopywriterListHandlerEventArgs e = new CopywriterListHandlerEventArgs(CopywriterCollectionName, " A default element was added to the collection  ", copywriter);
                CopywriterCountChanged(this, e);
                
            }
        }
        public void AddCopywriters(params Copywriter[] array)
        {
            if (ListOfCopywriters == null)
            {
                ListOfCopywriters = new List<Copywriter>();
            }
            ListOfCopywriters.AddRange(array);
            if (CopywriterCountChanged != null)
            {
                CopywriterListHandlerEventArgs e = new CopywriterListHandlerEventArgs(CopywriterCollectionName, " A new elements were added to the collection  ", ListOfCopywriters[ListOfCopywriters.Count - array.Length]);
                CopywriterCountChanged(this, e);

            }


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
        public bool Remove(int j)
        {
            if (ListOfCopywriters == null)
            {
                Console.WriteLine("The list is empty ");
            }

            if (ListOfCopywriters[j] == null)
                return false;
            else
            {
                if (CopywriterCountChanged != null)
                {
                    CopywriterListHandlerEventArgs e = new CopywriterListHandlerEventArgs(CopywriterCollectionName, " An element was removed from the collection  ", ListOfCopywriters[j]);
                    CopywriterCountChanged(this, e);

                }
                ListOfCopywriters.RemoveAt(j);
                for(int i = j; i < ListOfCopywriters.Count-1; i++)
                {
                    ListOfCopywriters[i] = ListOfCopywriters[i + 1];
                }
                
                return true;
                
            }

        }
        public Copywriter this[int index]
        {
            get
            {
                if (ListOfCopywriters==null)
                    Console.WriteLine("List is empty");
                return ListOfCopywriters[index];
            }
            set
            {
                    ListOfCopywriters[index] = value;
                if (CopywriterReferenceChanged != null)
                {
                    
                    CopywriterReferenceChanged(this, new CopywriterListHandlerEventArgs(CopywriterCollectionName, " Element in collection was changed ", ListOfCopywriters[index]));
                }
            }
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
