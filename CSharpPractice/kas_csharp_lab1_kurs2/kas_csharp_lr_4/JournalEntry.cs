using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class JournalEntry
    {
        public string CopywriterCollectionNameWithChanges { get; set; }
        public string CollectionChangesTypeInfo { get; set; }
        public string CopywriterInfo { get; set; }
        public JournalEntry()
        {
            CopywriterCollectionNameWithChanges = "Default Event collection name";
            CollectionChangesTypeInfo = "Default Collection changes type info";
            CopywriterInfo = "Default Copywriter info";
        }
        public JournalEntry(CopywriterListHandlerEventArgs e)
        {
            CopywriterCollectionNameWithChanges = e.CollectionWithChangesName;
            CollectionChangesTypeInfo = e.CollectionChangesTypeInfo;
            CopywriterInfo = e.ReferenceProperty.Nickname;
        }
        public override string ToString()
        {
            return string.Format("\n\n\nEvent collection name  " + CopywriterCollectionNameWithChanges + "\nCollection changes type info  " + CollectionChangesTypeInfo + "Copywriter info " + CopywriterInfo);
        }
    }
}
