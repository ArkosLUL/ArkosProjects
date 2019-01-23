using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp3l2k
{
    public interface IDateAndCopy
    {
        object DeepCopy();
        DateTime birth { get; set; }
    }
}