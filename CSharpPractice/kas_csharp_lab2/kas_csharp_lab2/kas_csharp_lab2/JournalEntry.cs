using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class JournalEntry<TKey>
    {
        string CollectionName { get; set; }
        Action ActionType { get; set; }
        string EventTriggerPropertyName { get; set; }
        string Key { get; set; }

        public JournalEntry()
        {
            CollectionName = "Default Event collection name";
            ActionType = 0;
            EventTriggerPropertyName = "Default property name that trigger an event";
            Key = " ";
        }
        public JournalEntry(CopywritersChangedEventArgs<TKey> e)
        {
            CollectionName = e.CollectionName;
            ActionType = e.ActionType;
            EventTriggerPropertyName = e.EventPropertyName;
            Key = e.Key.ToString();
        }

        public override string ToString()
        {
            return string.Format(new string('&', 50) +
                                                    "\nInformation about journal entry" +
                                                             "\n\tCollection name " + CollectionName+
                                                             "\n\tType of action " + ActionType +
                                                             "\n\tName of property that trigger an event " + EventTriggerPropertyName +
                                                             "\n\tKey " + Key +
                                                             "\n"+new string('&', 50));
        }
    }
}
