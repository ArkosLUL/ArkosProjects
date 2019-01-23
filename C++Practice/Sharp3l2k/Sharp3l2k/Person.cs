using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp3l2k
{
    class Person : IComparer<Person>, IComparable<Person>
    {
        protected string Name;
        protected string SecondName;
        protected DateTime Birth;
        public int Compare(Person A, Person B)
        {
            if (A.Birth > B.Birth)
                return 1;
            else
                if (A.Birth < B.Birth)
                return -1;
            else
                return 0;
        }
        public int CompareTo(Person per)
        {
            int result = String.Compare(this.SecondName, per.SecondName);
            if (result < 0)
            {
                return -1;
            }
            else
            if (result > 0)
            {
                return 1;
            }
            else
            {
                result = String.Compare(this.Name, per.Name);
                if (result < 0)
                {
                    return -1;
                }
                else
                if (result > 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string secondName
        {
            get
            {
                return SecondName;
            }
            set
            {
                SecondName = value;
            }
        }

        public DateTime birth
        {
            get
            {
                return Birth;
            }
            set
            {
                Birth = value;
            }
        }

        public int Year
        {
            get
            {
                return Birth.Year;
            }
            set
            {
                if (Birth.Year > 2018)
                    Birth = new DateTime(Birth.Day, Birth.Month, 1901);
            }

        }

        public virtual string ToShortString()
        {
            //return  String.Concat(Name, SecondName);
            return Name + " " + SecondName;
        }


        public override string ToString()
        {
            return Name + " " + SecondName + " " + Convert.ToString(Birth);
        }

        public Person(string Name, string SecondName, DateTime Birth)
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.Birth = Birth;
        }
        public Person()
        {
            Name = "Name";
            SecondName = "SecondName";
            Birth = new DateTime();
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is Person)
            {
                Person person = obj as Person;
                return this.ToString() == person.ToString();
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Person obj1, Person obj2)
        {
            return obj1.Equals(obj2);
        }
        public static bool operator != (Person obj1, Person obj2)
        {
            return !obj1.Equals(obj2);
        }
   /*     public virtual  DeepCopy()
        {
            return new Person(this.Name, this.SecondName, this.Birth);
        }*/

    }
}