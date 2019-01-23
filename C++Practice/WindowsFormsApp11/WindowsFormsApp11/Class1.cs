using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class NumArray
    {
        FileStream file1 = new FileStream("d:\\test.txt", FileMode.Open);
        StreamReader reader = new StreamReader(file1);
        public void Text()
        {
            label1.text = reader.ReadToEnd();
            reader.Close(); 
        }
    }
}
