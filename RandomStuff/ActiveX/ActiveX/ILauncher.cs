using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ActiveX
{
    public partial class ILauncher : Component
    {
        public ILauncher()
        {
            InitializeComponent();
        }



        [ComVisible(true)]
        [InterfaceType(ComInterfaceType.InterfaceIsDual)]
        [Guid("94D26775-05E0-4B9C-BC73-C06FE915CF89")]
        
    }
}


