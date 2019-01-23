using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Copywriter C1 = new Copywriter();
            Console.WriteLine(C1.ToShortString());
            C1 = new Copywriter(new Person("Artem", "Kosogov", new DateTime(2000, 05, 26)), "Arkos", 0, 100/*,  new Article[1] { new Article ("kas_csharp_lr_2", 40, new DateTime(2018, 04, 21))} */);
            Console.WriteLine(C1.ToString());
            Copywriter C2 = new Copywriter();
            C1.AddArticles(new Article[2]{ new Article ("kas_charp_lr_3", 35, new DateTime(2018, 04, 20)), new Article ("kas_charp_lr_4", 75, new DateTime(2018, 03, 15))});
            Console.WriteLine(C1.ToString());
            //Article[] Lists = new Article();
          //  Lists.
           // Article[] a1. = AddArticles { { "lr", 50, new DateTime(2018, 04, 22) } , { "lr2", 70, new DateTime(2018, 04, 23) } };
           // a1 = (new Article[]("lr", 50, new DateTime(2018, 04, 22)));
            Console.WriteLine("Average quantity of sings ={0}",C1.average_quantity_of_sings+"\n"); 
            


            // string str;

            //  str = Console.ReadLine();
            // string[] substring;
            Console.WriteLine("Enter the array dimension you can write it trough that delims , . / _  ! ? : \n");
            int[] size = Console.ReadLine().Split(new char[] { ',', '.', '/', '_', '!', ' ', '?', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray < int>();
           // substring = str.Split(',', ':', '.', '#', '?', '!', '*');
           int n, m;
            n = size[0];
            m = size[1];
          //  n = Convert.ToInt32(substring[0]);
            //m = Convert.ToInt32(substring[1]);
            Article[] dimension1 = new Article[n * m];
            Article[,] dimension2 = new Article[n,m];
            Article[][] dimension3 = new Article[n][];
            for (int i = 0; i < n; i++)
                dimension3[i] = new Article[m];          
           
            for (int i = 0; i < n * m; i++)
            {
                dimension1[i] = new Article();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dimension2[i, j] = new Article();
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dimension3[i][j] = new Article();
                }
            }
            int t1 = Environment.TickCount;
            for (int i = 0; i < n * m; i++)
            {
                dimension1[i].Quantity_of_sings = 10;
            }
            int t2 = Environment.TickCount;
             Console.WriteLine("Time for one dimension array = "+(t2-t1)+" quantity of row = " + n + " quantity of columns = " + m+"\n");
             int t3 = Environment.TickCount;
             for (int i = 0; i < n; i++)
             {
                 for (int j = 0; j < m; j++)
                 {
                     dimension2[i,j].Quantity_of_sings = 10;
                 }
             }
             int t4 = Environment.TickCount;
             Console.WriteLine("Time for two dimension array = "+(t4 - t3)+" quantity of row = "+ n+" quantity of columns = "+m+"\n");
             int t5 = Environment.TickCount;
             for (int i = 0; i < n; i++)
             {
                 for(int j = 0; j < m; j++)
                 {
                     dimension3[i][j].Quantity_of_sings = 10;
                 }
             }
             int t6 = Environment.TickCount;
             Console.WriteLine("Time for stepped dimension array = "+(t6 -t5)+ " quantity of row = " + n + " quantity of columns = " + m+"\n");
            Console.ReadKey();
        }
    }
}
