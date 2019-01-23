using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        [ComVisible(true)]
        [InterfaceType(ComInterfaceType.InterfaceIsDual), Guid("89a157ba-3fa1-470e-bffd-a583f9733b79")]
        public interface ILauncher
        {
            void launch();
        }

        [ClassInterface(ClassInterfaceType.None), Guid("9afaa639-dfb7-4617-b25d-f2b99ef50ae6"), ProgId("ClassLibrary1.Class1")]
        public class Launcher : ILauncher
        {
            private string path = null;

            public void launch()
            {
                Console.WriteLine("I launch scripts for a living.");

            }

        }
    }
}
