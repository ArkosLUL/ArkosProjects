using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceClass
{
    class PriseSortByProductName
    {
        public static void SortProductByName(ref Price[] priseArray)
        {
            List<Price> tempList = priseArray.ToList().OrderBy(x => x.ProductName).ToList();
            priseArray = tempList.ToArray();
            Console.WriteLine("Array of products was sorted by product name");
        }
    }
}
