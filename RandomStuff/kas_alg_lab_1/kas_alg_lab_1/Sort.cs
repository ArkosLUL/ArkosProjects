using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_alg_lab_1
{
    class Sort
    {
        public void InsertionSort(ref MyDict[] Dict, out int swapCount)
        {
            swapCount = 0;
            for (int i = 1; i < Dict.Length; i++)
            {
                int j;
                MyDict temp = new MyDict();
                for ( j = i-1; j >= 0; j--)
                {
                    if(Dict[j].Key.CompareTo(temp.Key)  < 0)
                    {
                        break;   
                    }
                    swapCount++;
                    Dict[j + 1] = Dict[j];
                    

                }
                Dict[j + 1] = temp;
                
            }
        }
    }
}
