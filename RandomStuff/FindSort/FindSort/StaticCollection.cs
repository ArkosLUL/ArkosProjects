using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStructKosogovArtemPZ171
{
    class StitcCollection
    {
        public static List<Item> Items = new List<Item>();
        public static void AddElements(string [] lines)
        {
            foreach (string str in lines)
            {
                string[] str1 = str.Split(new char[] { ' ' });
                bool flag = true;
                try
                {
                    foreach (Item i in Items)
                    {
                        if (i.key==Convert.ToInt32(str1[0]))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == true)
                    {
                        Items.Add(new Item(Convert.ToInt32(str1[0]), str1[1]));
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
