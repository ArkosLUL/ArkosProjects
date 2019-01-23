using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{

    class CopywriterCollection<TKey>
    {
        public delegate void CopywritersChangedHandler<TKey>(object source, CopywritersChangedEventArgs<TKey> args);
        public delegate void CopywriterListHandler(object source, CopywriterListHandlerEventArgs args);
        public event CopywriterListHandler CopywriterCountChanged;
        public event CopywritersChangedHandler<TKey> CopywritersChanged;
        public event CopywriterListHandler CopywriterReferenceChanged;
        public string CopywriterCollectionName { get; set; }
        public Dictionary<TKey, Copywriter> CopywriterDictionary;
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
            int average = 0;
            if (ListOfCopywriters.Count == 0)
                return 0;
            for (int i = 0; i < ListOfCopywriters.Count; i++)
            {
                average += ListOfCopywriters[i].Rating;
            }
            average = average / ListOfCopywriters.Count;
            return average;

        }
        /* public void AddDefaults()
         {

             if (ListOfCopywriters == null)
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
         } */
        public List<Copywriter> GetSortedListOfCopywriters()
        {
            if (ListOfCopywriters == null)
            {
                ListOfCopywriters = new List<Copywriter>();
            }
            if (CopywriterDictionary == null)
            {
                Console.WriteLine("Dictionary is empty, cannot sort list");
                return null;
            }
            else
            {
                ListOfCopywriters.AddRange(CopywriterDictionary.Values);
                List<Copywriter> sortedList = ListOfCopywriters.OrderBy(x => x.Rating).Reverse().ToList();

                return sortedList;
            }
        }

        public void AddCopywritersToDictionary(TKey key, Copywriter copywriter)
        {
            if (CopywriterDictionary == null)
            {
                CopywriterDictionary = new Dictionary<TKey, Copywriter>();
            }
            CopywriterDictionary.Add(key, copywriter);
            copywriter.PropertyChanged += DictionaryHandler;
            CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CopywriterCollectionName, Action.Add, "", key));
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
            foreach (Copywriter p in ListOfCopywriters)
            {
                str += p.ToShortString();
            }
            return str;
        }
        public bool Remove(Copywriter cw)
        {
            TKey key;
            if (CopywriterDictionary == null)
            {
                Console.WriteLine("The dictionary is empty ");
                return false;
            }
            else
            {
                if (CopywriterDictionary.ContainsValue(cw) == false)
                    return false;
                else
                {
                    key = CopywriterDictionary.First(x => x.Value == cw).Key;
                    cw.PropertyChanged -= DictionaryHandler;
                    CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CopywriterCollectionName, Action.Remove, "", key));
                    return CopywriterDictionary.Remove(key);
                }
            }
        }
        public Copywriter this[TKey key]
        {
            get
            {
                if (CopywriterDictionary == null)
                {
                    Console.WriteLine("Dictionary is empty");
                    return null;
                }
                try { return CopywriterDictionary[key]; }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
            set
            {
                try { CopywriterDictionary[key] = value; }
                catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
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

        private void DictionaryHandler(object source, PropertyChangedEventArgs e)
        {
            CopywritersChanged?.Invoke(this, new CopywritersChangedEventArgs<TKey>(CopywriterCollectionName, Action.Property, e.PropertyName, CopywriterDictionary.First(x => x.Value.Equals(source)).Key));
        }
    }
}
