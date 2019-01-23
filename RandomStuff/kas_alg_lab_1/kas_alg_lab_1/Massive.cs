using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kas_alg_lab_1
{
    
        class Massive
        {
            DataGridView dataGridView;
            public int counter { get; set; }//счётчик количества записей 
            public Massive(DataGridView recieverDataGridView)
            {
                dataGridView = recieverDataGridView;
            }
            public MyDict[] Records;
            private int GetMinIndex(int currIndex)//ф-ия возвращает идекс минимального элемента в массиве
            {
                string curr = this.Records[currIndex].Key;
                int j = currIndex;
                for (int i = currIndex; i < this.counter; i++)
                    if (curr.CompareTo(Records[i].Key) == 1)
                    {
                        curr = this.Records[i].Key;
                        j = i;
                    }
                return j;
            }
            public void OpenMass(string name)
            {
                StreamReader reader = File.OpenText(name);
                string line;
                string[] fields;
                if (!reader.EndOfStream)
                {
                    counter = Convert.ToInt32(reader.ReadLine());
                    MyDict[] TmpMass = new MyDict[counter];

                    for (int i = 0; i < counter; i++)
                    {

                        line = reader.ReadLine();
                        line = line.Trim();
                        fields = line.Split('_');//шайтанама над строками . разбиваем по разделителю _
                        TmpMass[i] = new MyDict();
                        TmpMass[i].Key = fields[0];
                        TmpMass[i].Txtinfo = fields[1];// прописали поля
                    }
                    Records = TmpMass;
                    TmpMass = null;
                }
                reader.Dispose();
            }
            public void GetRecordsFromVirtual(ListStruct source)//брать записи из источника в качестве списка
            {
                this.counter = source.counter;
                TabStud Record = source.ListRecord;//обьявили и присвоили запись шоб ходить по списку не изменяя головы

                this.Records = new TabStud[source.counter];
                for (int i = 0; i < source.counter - 1; i++)
                {

                    this.Records[i] = Record;
                    Record = Record.Next;
                }
                this.Records[source.counter - 1] = Record;
            }

            public ListStruct SetRecordsToVirtual()// если  в последствии используемый алгоритм изменит данные, то 
            {//выполниим эту функцию которая вернет в место назначения список..
             //ток через ретурнс ибо свойства нельзя передавать как пареметр через реф!!
                var dest = new ListStruct(DGV);
                // /*this.Records[0].Next =*/ this.Records[this.counter - 1].Next = null;
                TabStud Record = this.Records[0];//записали какбэ голову
                dest.ListRecord = Record;//и отдали в дест
                dest.LastOf = this.Records[this.counter - 1];
                dest.LastOf.Next = null;
                dest.counter = this.counter;
                for (int i = 0; i < (this.counter - 2); i++)
                {
                    this.Records[i].Next = this.Records[i + 1];
                    Record = this.Records[i];
                    Record = Record.Next;
                }
                this.Records[this.counter - 2].Next = this.Records[this.counter - 1];
                return dest;
            }
            public void SaveMass(string name)
            {
                StreamWriter writer = File.CreateText(name);
                for (int i = 0; i < counter; i++)
                {
                    writer.WriteLine(Records[i].Key + '_' + Records[i].Txtinfo);
                }
                writer.Close();
                writer.Dispose();
            }
            public void FillDG()
            {
                DGV.RowCount = Records.Length;
                for (int i = 0; i < this.counter; i++)
                {
                    //DG.Rows.Insert(DG.RowCount - 1, 1);
                    DGV[0, i].Value = Records[i].Key;

                    DGV[1, i].Value = Records[i].Txtinfo;
                }
                DGV.Enabled = true;
            }
            public TabStud BinarySearch(string LookingKey)
            {
                int left, right, i;
                left = 0;
                right = this.Records.GetLength(0) - 1;
                i = (left + right) / 2;
                while (LookingKey.CompareTo(this.Records[i].Key) != 0 && left <= right) //do
                {

                    if (LookingKey.CompareTo(this.Records[i].Key) == -1)
                    {
                        right = i - 1;
                    }
                    else
                    {
                        left = i + 1;
                    }
                    i = (left + right) / 2;
                }


                return (left > right) ? null : this.Records[i];
            }
            public TabStud HomoBinarySearch(string LookingKey, int[] D)
            {
                int left, right;
                left = 0;
                right = this.Records.GetLength(0) - 1;
                int i = D[1], j = 2;
                //i = (left + right) / 2;
                while (LookingKey.CompareTo(this.Records[i].Key) != 0) //do
                {

                    if (LookingKey.CompareTo(this.Records[i].Key) == -1)
                    {
                        if (D[j] == 0) return null;
                        else
                        { i = i - D[j]; j++; }
                    }
                    else
                    {
                        if (D[j] == 0) return null;
                        else
                        { i = i + D[j]; j++; }
                    }
                   ;
                }


                return (left > right) ? null : this.Records[i];
            }
            public void QuickSort()
            {
                QSort(0, counter - 1);
            }
            private void QSort(int first, int last)//*ref int[] M, Int64 first, Int64 last, out double sec*/)
            {

                string p = Records[(last - first) / 2 + first].Key;
                TabStud temp;
                int i = first, j = last;
                while (i <= j)
                {
                    while (Records[i].Key.CompareTo(p) == -1 && i <= last) ++i;
                    while (Records[j].Key.CompareTo(p) == 1 && j >= first) --j;
                    if (i <= j)
                    {
                        temp = Records[i];
                        Records[i] = Records[j];
                        Records[j] = temp;
                        ++i; --j;
                    }
                }
                if (j > first) QSort(first, j);
                if (i < last) QSort(i, last);

            }

            public void BulbSort()
            {

                for (Int64 i = 0; i < Records.Length; i++)
                {
                    bool f = true;
                    for (Int64 j = 0; j < Records.Length; j++)
                    {

                        if (Records[i].Key.CompareTo(Records[j].Key) == -1) { TabStud tmp = Records[i]; Records[i] = Records[j]; Records[j] = tmp; f = false; }
                    }

                    if (f) break;
                }
            }
            public void PSort()
            {
                DateTime start = DateTime.Now;


                TabStud[] FM = new TabStud[this.Records.LongLength];
                int[] c = new int[this.Records.LongLength];
                for (Int64 i = 0; i < this.Records.LongLength; i++) c[i] = 0;

                for (Int64 i = 0; i < this.Records.LongLength - 1; i++)
                {
                    for (Int64 j = i + 1; j < this.Records.LongLength; j++)
                    {
                        if (this.Records[i].Key.CompareTo(this.Records[j].Key) == 1)
                            c[i]++;
                        else
                            c[j]++;
                    }
                }
                for (Int64 i = 0; i < this.Records.LongLength; i++)
                    FM[c[i]] = this.Records[i];
                this.Records = FM;
            }
            public void SelectSort()
            {
                int i;
                for (i = 0; i < this.counter; i++)
                {

                    int minIndex = this.GetMinIndex(i);
                    TabStud tmp = this.Records[minIndex];
                    this.Records[minIndex] = this.Records[i];
                    this.Records[i] = tmp;

                }

            }
            public TabStud[] mergeSort(TabStud[] massive)
            {
                if (massive.Length == 1)
                    return massive;
                Int32 mid_point = massive.Length / 2;
                TabStud[] M1 = new TabStud[mid_point];
                for (int i = 0; i < mid_point; i++)
                    M1[i] = massive[i];
                TabStud[] M2 = new TabStud[massive.Length - mid_point];
                for (int i = 0; i < massive.Length - mid_point; i++)
                    M2[i] = massive[i + mid_point];


                return Merge(mergeSort(M1), mergeSort(M2));

            }
            public TabStud[] Merge(TabStud[] mass1, TabStud[] mass2)
            {
                Int32 a = 0, b = 0;
                TabStud[] merged = new TabStud[mass1.Length + mass2.Length];
                for (Int32 i = 0; i < mass1.Length + mass2.Length; i++)
                {
                    if (b < mass2.Length && a < mass1.Length)
                        if (mass1[a].Key.CompareTo(mass2[b].Key) == 1 && b < mass2.Length)
                            merged[i] = mass2[b++];
                        else
                            merged[i] = mass1[a++];
                    else
                        if (b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                }
                return merged;
            }
        }

