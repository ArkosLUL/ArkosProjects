using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class Journal
    {
        private List<JournalEntry> journalEntryList;
        public List<JournalEntry> JournalEntryList
        {
            get
            {
                return journalEntryList;
            }
            set
            {
                journalEntryList = value;
            }
        }
        
        public void CopywriterCountChanged(object source, CopywriterListHandlerEventArgs e)
        {
            if(JournalEntryList == null)
            {
                JournalEntryList = new List<JournalEntry>();
            }
           JournalEntryList.Add(new JournalEntry(e));
           Console.WriteLine(e.CollectionChangesTypeInfo);
        }
        public void CopywriterReferenceChanged(object source, CopywriterListHandlerEventArgs e)
        {
            if (JournalEntryList ==null)
            {
                JournalEntryList = new List<JournalEntry>();
            }
            JournalEntryList.Add(new JournalEntry(e));
            Console.WriteLine(e.CollectionChangesTypeInfo);
        }
        public override string ToString()
        {
            if (JournalEntryList == null)
            {
               return "Nothing happened\n";
            }
            else
            {
                string str = "";
                foreach (JournalEntry p in JournalEntryList)
                {
                    str += p.ToString() + "&&&&&&&";
                }
                return str;
            }
        }

    }
}
