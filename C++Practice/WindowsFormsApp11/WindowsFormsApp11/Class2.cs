using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Sorts
    {
        public void Shakersort(int[] A)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i <= A.Length - 2; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
                swapped = false;
                for (int i = A.Length - 2; i >= 0; i--)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        //public void
    }
}
