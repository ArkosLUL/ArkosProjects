using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharp3l2k
{
    class Group
    {
        public int Year
        {
            get;
            set;
        }

        public string GroupName
        {
            get;
            set;
        }

        public int Amount
        {
            get;
            set;
        }
        public Group(int Year, string Class, int Amount)
        {
            this.Year = Year;
            this.GroupName = Class;
            this.Amount = Amount;
        }
        public Group()
        {
            this.Year = 1901;
            this.GroupName = "Cipher";
            this.Amount = 0;
        }

        public override string ToString()
        {
            return Year + ", " + GroupName + ", " + Convert.ToString(Amount) + "; ";
        }
        public object DeepCopy()
        {
            return new Group(this.Year, this.GroupName, this.Amount);
        }
        /*  public override int GetHashCode()
          {
              return this.ToString().GetHashCode();
          }
          public static bool operator == (Group obj1, Group obj2)
          {
              return obj1.Equals(obj2);
          }
          public static bool operator != (Group obj1, Group obj2)
          {
              return !obj1.Equals(obj2);
          }
          public override bool Equals(object obj)
          {
              if (obj == null)
                  return false;
              if (obj is Group)
              {
                  Group group = obj as Group;
                  return obj.ToString() == group.ToString();
              }
              else
                  return false;
          }*/
    }
}