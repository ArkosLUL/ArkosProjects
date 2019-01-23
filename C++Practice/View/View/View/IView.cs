using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.View
{
    public interface IView
    {
        string ContactName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string EMail { get; set; }
        string Skype { get; set; }
        string Search { get; set; }
    }
}
