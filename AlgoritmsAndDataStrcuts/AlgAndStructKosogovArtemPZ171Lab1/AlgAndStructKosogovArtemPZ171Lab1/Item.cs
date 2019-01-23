using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStructKosogovArtemPZ171
{
    class Item
    {
        public int key;
        public string value;
        public Item(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
        public override string ToString()
        {
            return key + " " + value;
        }
        public override bool Equals(object obj)
        {
            if (obj is Item)
            {
                return this.ToString() == obj.ToString();
            }
            else return false;
        }
        public static bool operator ==(Item i1, Item i2)
        {
            return i1.Equals(i2);
        }
        public static bool operator !=(Item i1, Item i2)
        {
            return !i1.Equals(i2);
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public virtual object DeepCopy()
        {
            Item obj = new Item(this.key, this.value);
            return obj;
        }
    }
}
