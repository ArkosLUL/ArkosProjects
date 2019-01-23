using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_4
{
    class TestCollections
    {
        private List<Person> TestPersonList = new List<Person>();
        private List<string> TestStringList = new List<string>();
        private Dictionary<Person, Copywriter> TestPersonDictionary = new Dictionary<Person, Copywriter>();
        private Dictionary<string, Copywriter> TestStringDictionary = new Dictionary<string, Copywriter>();
        public static Copywriter CollectionAvtoGeneration(int n)
        {
            Copywriter c = new Copywriter();
            c.Name += String.Format("askjdklajs{0}", n);
            return c;
        }
        public TestCollections(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Copywriter c = CollectionAvtoGeneration(i);
                TestPersonList.Add(c as Person);
                TestStringList.Add(c.ToString());
                TestPersonDictionary.Add(c as Person, c);
                TestStringDictionary.Add(c.ToString(), c);
            }
        }
        public string Time(int n)
        {
            //Copywriter c = new Copywriter() { Name = String.Format("askjdklajs{0}", n) };
            Copywriter c = CollectionAvtoGeneration(n);
            string info = "";
            bool temp;
            System.Diagnostics.Stopwatch time = new System.Diagnostics.Stopwatch();
            time.Start();
            Person temp1 = c as Person;
            temp = TestPersonList.Contains(temp1);
            time.Stop();
            info += String.Format("Element searching time in List<Team> - {0}  {1}\n", time.Elapsed, temp);

            time.Reset();
            time.Start();
            string temp2 = c.ToString();
            temp = TestStringList.Contains(c.Person.ToString());
            time.Stop();
            info += String.Format("Element searching time in List<string> - {0}   {1}\n", time.Elapsed, temp);

            time.Reset();
            time.Start();
            temp = TestPersonDictionary.ContainsKey(c.Person);
            time.Stop();
            info += String.Format("Element searching time by key in Dictionary<Person,Copywriter> - {0}   {1}\n", time.Elapsed, temp);

            time.Reset();
            time.Start();
            temp = TestPersonDictionary.ContainsValue(c);
            time.Stop();
            info += String.Format("Element searching time by value in Dictionary<Person,Copywriter> - {0}   {1}\n", time.Elapsed, temp);

            time.Reset();
            time.Start();
            temp = TestStringDictionary.ContainsKey(c.Person.ToString());
            time.Stop();
            info += String.Format("Element searching time by key in Dictionary<string,Copywriter> - {0}   {1}\n", time.Elapsed, temp);

            time.Reset();
            time.Start();
            temp = TestStringDictionary.ContainsValue(c);
            time.Stop();
            info += String.Format("Element searching time by value in Dictionary<string,Copywriter> - {0}   {1}\n", time.Elapsed, temp);

            return info;
        }
        //public TestCollections()
        //{
        //    TestPersonList = new List<Person>();
        //    TestStringList = new List<string>();
        //    TestPersonDictionary = new Dictionary<Person, Copywriter>();
        //    TestStringDictionary = new Dictionary<string, Copywriter>();
        //}
    }
}
