using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Sharp3l2k
{
    [Serializable]
    class Teacher : Person, INotifyPropertyChanged
    {
        private string Subject;
        private int Salary;
        private List<Group> GroupList = new List<Group>();
        public event PropertyChangedEventHandler PropertyChanged;
        public bool AddFromConsole()
        {
            try
            {
                string[] strGroup = Console.ReadLine().Split(new char[] { ';' }, 3);
                GroupList.Add(new Group(Convert.ToInt32(strGroup[0]), strGroup[1], Convert.ToInt32(strGroup[2])));
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Save(string filename)
        {
            /*          using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                           {
                                formatter.Serialize(fs, this);
                                return b;
                           }
                      return false;
                          */
            FileStream fs = null;
            BinaryFormatter formatter = new BinaryFormatter();
            bool b = true;
            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate);
                formatter.Serialize(fs, this);
                b = true;
            }
            catch
            {
                b = false;
            }
            finally
            {
                fs.Dispose();
            }
            return b;
        }
        public bool Load(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = null;
            bool b = true;
            Teacher tc_copy = this.DeepCopy();
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                //   tc as formatter.Deserialize(fs);
                InTeacher((Teacher)(formatter.Deserialize(fs)));
                b = true;
            }
            catch
            {
                b = false;
                InTeacher(tc_copy);
            }
            finally
            {
                fs.Dispose();
            }
            return b;

        }
        public static bool Save(string filename, Teacher tc)
        {
            /*          using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                           {
                                formatter.Serialize(fs, this);
                                return b;
                           }
                      return false;
                          */
            FileStream fs = null;
            BinaryFormatter formatter = new BinaryFormatter();
            bool b = true;
            try
            {
                fs = new FileStream(filename, FileMode.OpenOrCreate);
                formatter.Serialize(fs, tc);
                b = true;
            }
            catch
            {
                b = false;
            }
            finally
            {
                fs.Dispose();
            }
            return b;
        }
        public static bool Load(string filename, Teacher tc)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = null;
            bool b = true;
            Teacher tc_copy = tc.DeepCopy();
            try
            {
                fs = new FileStream(filename, FileMode.Open);
                //   tc as formatter.Deserialize(fs);
                //   tc = (Teacher)(formatter.Deserialize(fs));
                b = true;
            }
            catch
            {
                b = false;
                tc = tc_copy;
            }
            finally
            {
                fs.Dispose();
            }
            return b;

        }
        public Teacher DeepCopy()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            Teacher tc_copy = new Teacher();
            try
            {
                formatter.Serialize(ms, this);
                tc_copy = (Teacher)formatter.Deserialize(ms);
            }
            catch
            {
                tc_copy = this;
            }
            finally
            {
                ms.Dispose();
            }
            return tc_copy;

        }

        public Person data
        {
            get
            {
                return new Person(Name, SecondName, Birth);
            }
            set
            {
                this.Name = value.name;
                this.SecondName = value.secondName;
                this.Birth = value.birth;
            }
        }

        public string subject
        {
            get
            {
                return Subject;
            }
            set
            {
                Subject = value;
                if (PropertyChanged != null)
                {
                    PropertyChangedEventArgs e = new PropertyChangedEventArgs("Предмет изменён");
                    PropertyChanged(this, e);
                }
            }
        }



        public int salary
        {
            get
            {
                return Salary;
            }
            set
            {
                if (value <= 1000 || value > 5000)
                    throw new Exception("Таких зарплат не бывает! Допустимые границы от 1000 до 5000");
                else
                    Salary = value;
            }
        }

        public List<Group> grouplist
        {
            get
            {
                return GroupList;
            }
            set
            {
                GroupList = value;
            }
        }
        public void AddGroup(params Group[] gr)
        {
            for (int i = 0; i < gr.Length; i++)
                GroupList.Add(gr[i]);

        }


        public int amount
        {
            get
            {
                int amount = 0;
                /*for (int i = 0; i < GroupList.Length; i++)
                    amount += GroupList[i].Amount;*/
                foreach (Group el in GroupList)
                    amount += el.Amount;
                return amount;
            }
        }



        public Teacher(Person Data, string Subject, int Salary) : base(Data.name, Data.secondName, Data.birth)
        {
            this.Subject = Subject;
            this.Salary = Salary;
        }

        public Teacher() : base()
        {
            Subject = "Subject";
            Salary = 0;

        }
        public void InTeacher(Teacher tc)
        {
            Birth = tc.Birth;
            SecondName = tc.SecondName;
            Name = tc.Name;
            Subject = tc.Subject;
            Salary = tc.Salary;
            GroupList = tc.GroupList;
        }
        public override string ToShortString()
        {
            return Name + " " + SecondName + " " + Convert.ToString(Birth) + "; " + Subject + "; " + Convert.ToString(Salary) + "; " + Convert.ToString(amount);
        }



        public override string ToString()
        {
            string strGroupList = "\0";
            foreach (Group el in GroupList)
                strGroupList += el.ToString();
            return Name + " " + SecondName + " " + Convert.ToString(Birth) + "; " + Subject + "; " + "; " + Convert.ToString(Salary) + "; " + Convert.ToString(amount) + "; " + strGroupList + ".";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj is Teacher)
            {
                Teacher teacher = obj as Teacher;
                return this.ToString() == teacher.ToString();
            }
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public IEnumerable<object> GroupIterator(int n)
        {
            int max = GroupList.Count;
            for (int i = 0; i < max; i++)
            {
                if (GroupList[i].Amount < n)
                {
                    yield return GroupList[i];
                }
            }
        }
        public IEnumerable<object> Iterator()
        {

            for (int i = 0; i < grouplist.Count; i++)
            {
                yield return grouplist[i];
            }
        }

    }
}