﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Copywriter C1 = new Copywriter();
            Console.WriteLine(C1.ToShortString());
            Console.WriteLine(C1.ToString());
            Copywriter C2 = new Copywriter();
            Console.WriteLine(C1.Equals(C2));
            Console.WriteLine(ReferenceEquals(C1, C2));
            Console.WriteLine("\n Hash code 1 " + Convert.ToString(C1.GetHashCode()) + " Hash code 2 " + Convert.ToString(C2.GetHashCode()));
            C1 = new Copywriter(new Person("Artem", "Kosogov", new DateTime(2000, 05, 26)), "Arkos", 0, 3);
            C1.AddArticles(new Article[2] { new Article("kas_charp_lr_3", 35, new DateTime(2018, 04, 20)), new Article("kas_charp_lr_4", 75, new DateTime(2018, 03, 15)) });
            C1.AddOrders(new Order[2] { new Order("Flowers", new DateTime(2018, 05, 21), 8), new Order("Cleaning", new DateTime(2018, 05, 21), 4) });
            Console.WriteLine(" asd" + C1.Person.ToString());
            object obj = C1.DeepCopy();

            Copywriter C3 = obj as Copywriter;
            C1.Name = "Artur";
            C1.ListInformationAboutCopywriterArticles[0].Article_name = "000000000000000000000000000000000000000000000";
            Console.WriteLine("DEEP COPY OBJECT &&&&&&&&&&&&\n");
            Console.WriteLine(C3.ToString());
            Console.WriteLine("ORIGINAL OBJECT  ^^^^^^^^^^^^^\n");
            Console.WriteLine(C1.ToString());
            Console.WriteLine(obj);

            Console.WriteLine("ADDED ORDERS AND ARTICLES ***********\n");
            Console.WriteLine(C1.ToString());
            C1.ListInformationAboutCopywriterArticles[0] = new Article("Article 1", 50, new DateTime(2000, 10, 01));
            Console.WriteLine("All orders and articles\n ");
            foreach (var p in C1.GetArticleAndOrder())
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("All orders lower than 10 hours\n");
            foreach (var p in C1.GetOrders(10))
            {
                Console.WriteLine(p);
            }
            try
            {
                C1.Rating = 10;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error    " + ex.Message);
            }
            Console.WriteLine("Average quantity of sings ={0}", C1.AverageQuantityOfSings+ "\n");



            // string str;

            //  str = Console.ReadLine();
            // string[] substring;
            Console.WriteLine("Enter the array dimension you can write it trough that delims , . / _  ! ? : \n");
            int[] size = Console.ReadLine().Split(new char[] { ',', '.', '/', '_', '!', ' ', '?', ':' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray<int>();
            // substring = str.Split(',', ':', '.', '#', '?', '!', '*');
            int n, m;
            n = size[0];
            m = size[1];
            //  n = Convert.ToInt32(substring[0]);
            //m = Convert.ToInt32(substring[1]);
            Article[] dimension1 = new Article[n * m];
            Article[,] dimension2 = new Article[n, m];
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
            Console.WriteLine("Time for one dimension array = " + (t2 - t1) + " quantity of row = " + n + " quantity of columns = " + m + "\n");
            int t3 = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dimension2[i, j].Quantity_of_sings = 10;
                }
            }
            int t4 = Environment.TickCount;
            Console.WriteLine("Time for two dimension array = " + (t4 - t3) + " quantity of row = " + n + " quantity of columns = " + m + "\n");
            int t5 = Environment.TickCount;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dimension3[i][j].Quantity_of_sings = 10;
                }
            }
            int t6 = Environment.TickCount;
            Console.WriteLine("Time for stepped dimension array = " + (t6 - t5) + " quantity of row = " + n + " quantity of columns = " + m + "\n");
            CopywriterCollection cc = new CopywriterCollection();
            cc.AddCopywriters(C1, C3);
            cc.AddDefaults();
            
            
            cc.SortByLastName();
            Console.WriteLine(cc.ToShortString());
            cc.SortByBirthDate();
            cc.SortByAveregeQuantityOfSings();
            Console.WriteLine(cc.ToString());
            //try
            //{ 
            Person person = new Person(); 
                TestCollections tc = new TestCollections(1000);
                Console.WriteLine(String.Format("First element:\n" + tc.Time(1) + "Central element:\n" + tc.Time(500) + "Last element:\n" + tc.Time(1000) + "Element not in collection: \n" + tc.Time(2000)));
            //}
            //catch (InvalidOperationException) { Console.WriteLine( " NWn " ); }
            Console.WriteLine(cc.ToShortString());
            Console.ReadKey();
        }
    }
}
