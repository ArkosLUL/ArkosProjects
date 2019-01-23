using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIndAndReplaceManager
{
    static class FindAndReplaceManager
    {
        public static bool FindNext(string whatToFind, string whereToFind)
        {
            return whereToFind.Contains(whatToFind);
        }
    }
}
