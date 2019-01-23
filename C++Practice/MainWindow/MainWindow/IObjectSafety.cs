using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MainWindow
{
    
        [ComImport()]
        [Guid("51105418-2E5C-4667-BFD6-50C71C5FD15C")]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        interface IObjectSafety
        {
            [PreserveSig()]
            int GetInterfaceSafetyOptions(ref Guid riid, out int pdwSupportedOptions, out int pdwEnabledOptions);
            [PreserveSig()]
            int SetInterfaceSafetyOptions(ref Guid riid, int dwOptionSetMask, int dwEnabledOptions);
        }
}
