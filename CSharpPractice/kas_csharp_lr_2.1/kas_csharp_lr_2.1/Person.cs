﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kas_csharp_lr_2._1
{
    public class Person
    {
        private string name;
        private string last_name;
        private DateTime birth_date;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Last_Name
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }
        public DateTime Birth_Date
        {
            get
            {
                return birth_date;
            }
            set
            {
                birth_date = value;
            }
        }
        public int Birth_Date_changer
            {
                get
                {
                    return birth_date.Year;
                }
                set
                {
               birth_date = new DateTime(value, birth_date.Month, birth_date.Day);
                }
            }
        public Person(string name, string last_name, DateTime birth_date)
        {
            this.name = name;
            this.last_name = last_name;
            this.birth_date = birth_date;
        }
        public Person()
        {
            this.name = "Blank";
            this.last_name = "Blank";
            this.birth_date = DateTime.Today;
        }
        public override string ToString()
        {
            return String.Format("Name: "+name+" Last name: "+last_name+" Birth date: "+birth_date);
        }
        public string ToShortString()
        {
            return String.Format("Name: "+name + " Last name: " + last_name);
        }
    }
}

