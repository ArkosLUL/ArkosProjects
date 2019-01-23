using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kas_alg_lab_1
{
    public class MyDict
    {
        public DataGridView dataGridView;
        private string key;
        private string value;

        public MyDict()
        {
            Key = "";
            Value = "";
        }


        public static void Swap(MyDict md1, MyDict md2)
        {
            MyDict tmp = new MyDict(md1.Key, md1.Value);
            Copy(md1, md2);
            Copy(md2, tmp);
        }

        public MyDict(string key, string value)
        {
            Key = key;
            Value = value;
        }
        public string Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public static void Copy(MyDict to, MyDict from)
        {
            to = new MyDict(from.Key, from.Value);
        }
        public override bool Equals(object obj)
        {
            if (obj is MyDict)
                return this.ToString() == obj.ToString();
            else return false;
        }

        public bool Equals(MyDict md)
        {
            return this.ToString() == md.ToString();
        }

        public override string ToString()
        {
            return "Ключ = " + Key.ToString() + "Значение = " + Value.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
