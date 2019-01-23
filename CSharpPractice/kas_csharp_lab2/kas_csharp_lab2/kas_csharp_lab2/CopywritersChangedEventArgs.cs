using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    public class CopywritersChangedEventArgs<TKey> : EventArgs
    {

        public string CollectionName { get; set; }
        public Action ActionType { get; set; }
        public string EventPropertyName { get; set; }
        public TKey Key {get;set;}

        public CopywritersChangedEventArgs(string CollectionName, Action ActionType, string EventPropertyName, TKey Key)
        {
            this.CollectionName = CollectionName;
            this.ActionType = ActionType;
            this.EventPropertyName = EventPropertyName;
            this.Key = Key;
        }

        public override string ToString()
        {
            return string.Format(new string ('-',50)+$"\n\tCollection name --> {CollectionName};\n\tAction type --> {ActionType}; \n\tProperty name that trigger event --> {EventPropertyName}; \n\t Element key that was added, removed or changed --> {Key}\n" + new string('-', 50));
        }
    }
}
