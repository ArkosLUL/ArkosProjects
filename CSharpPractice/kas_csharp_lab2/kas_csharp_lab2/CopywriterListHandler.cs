using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    public class CopywriterListHandlerEventArgs : EventArgs
    {
        public string CollectionWithChangesName { get; set; }
        public string CollectionChangesTypeInfo { get; set; }
        public Copywriter ReferenceProperty {get; set;}
        public CopywriterListHandlerEventArgs()
        {
            CollectionWithChangesName = "Default CollectionWithChangesName";
            CollectionChangesTypeInfo = "Default CollectionChangesTypeInfo";
            ReferenceProperty = null;
        }
        public CopywriterListHandlerEventArgs(string collectionWithChangesName, string collectionChangesTypeInfo, Copywriter referenceProperty)
        {
            CollectionWithChangesName = collectionWithChangesName;
            CollectionChangesTypeInfo = collectionChangesTypeInfo;
            ReferenceProperty = referenceProperty;
        }
        public override string ToString()
        {
            return string.Format("\n\n\nCollection with changes name  " + CollectionWithChangesName + "\nCollection with changes type info  " + CollectionChangesTypeInfo + "\n Reference  " + ReferenceProperty);
        }
    }
}
