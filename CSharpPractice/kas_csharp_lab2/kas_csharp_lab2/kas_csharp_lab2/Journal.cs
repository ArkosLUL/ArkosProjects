using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class Journal<TKey>
    {
        List<JournalEntry<TKey>> journal;

        public void CopywritersChanged(object source, CopywritersChangedEventArgs<TKey> e)
        {
            if (journal == null)
            {
                journal = new List<JournalEntry<TKey>>();
            }
            journal.Add(new JournalEntry<TKey>(e));
        }

        public override string ToString()
        {
            if (journal == null)
            {
                return "Nothing happened\n";
            }
            else
            {
                string str = "";
                foreach (JournalEntry<TKey> p in journal)
                {
                    str += p.ToString();
                }
                return str;
            }

        }
    }
}
