using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_zadachka
{

     public class Notebook
        {
          public string Model
        { get; set; }
        public int Price
        { get; set; }
        public bool Trial(Notebook param)
        {
            
            
                return param.Price >= 1000;
            

        }   
        }
     class Program
    {
       static int Main()
        {
            Notebook n1 = new Notebook();
            n1.Price = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("{0}", n1.Trial(n1));
            Console.ReadKey();
            return 0;
        }
    }
}
