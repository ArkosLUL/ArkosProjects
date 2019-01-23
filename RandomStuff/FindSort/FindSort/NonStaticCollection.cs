using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgAndStructKosogovArtemPZ171
{
    class NonStaticCollection
    {
        public List<Item> Items = new List<Item>();
        public NonStaticCollection()
        {
            foreach (Item i in StitcCollection.Items)
            {
                Items.Add((Item)i.DeepCopy());
            }
        }
        public Item this[int index]
        {
            get
            {
                return Items[index];
            }
            set
            {
                Items[index] = value;
            }
        }
        public void BubbleSort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                for (int j = 0; j < Items.Count - 1; j++)
                {
                    if (Items[j].key > Items[j + 1].key)
                    {
                        Item temp = Items[j];
                        Items[j] = Items[j + 1];
                        Items[j + 1] = temp;
                    }
                }
            }
        }
        public void InsertionSort(out int counter)
        {
            Item tmp;
            counter = 0;
            int item; // индекс предыдущего элемента
            for (int i = 1; i < Items.Count; i++)
            {
                tmp = Items[i]; // инициализируем временную переменную текущим значением элемента массива
                item = i - 1; // запоминаем индекс предыдущего элемента массива
                while (item >= 0 && Items[item].key > tmp.key) // пока индекс не равен 0 и предыдущий элемент массива больше текущего
                {
                    Items[item + 1] = Items[item]; // перестановка элементов массива
                    Items[item] = tmp;
                    item--;
                    counter++;
                }
            }
        }
        public void SelectionSort(out int counter)
        {
            counter = 0;
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[j].key < Items[min].key)
                    {
                        min = j;
                    }
                }
                Item tmp = Items[i];
                Items[i] = Items[min];
                Items[min] = tmp;
                min = i;
                counter++;
            }
        }
        public void QuickSort(out int counter)
        {
            counter = 0;
            if (Items.Count > 0)
            {
                QSorting(Items, 0, Items.Count - 1, ref counter);
            }
        }
        public void QSorting(List<Item> a, int first, int last, ref int counter)
        {
            Item mid = a[(last - first) / 2 + first];
            Item temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (a[i].key < mid.key && i <= last) { i++; }
                while (a[j].key > mid.key && j >= first) { j--; }
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++; j--;
                    counter++;
                }
            }
            if (j > first) QSorting(a, first, j, ref counter);
            if (i < last) QSorting(a, i, last, ref counter);
        }
        public void ShakerSort(out int counter)
        {
            counter = 0;
            int left = 0, right = Items.Count - 1;
            while (left <= right)
            {
                for (int i = left; i < right; i++)  //Сдвигаем к концу массива "тяжелые элементы"
                {
                    if (Items[i].key > Items[i + 1].key)
                    {
                        Item tmp = Items[i];
                        Items[i] = Items[i+1];
                        Items[i+1] = tmp;
                        counter++;
                    }
                }
                right--;// уменьшаем правую границу
                for (int i = right; i > left; i--) //Сдвигаем к началу массива "легкие элементы"
                {
                    if (Items[i - 1].key > Items[i].key)
                    {
                        Item tmp = Items[i-1];
                        Items[i-1] = Items[i];
                        Items[i] = tmp;
                        counter++;
                    }
                }
                left++; // увеличиваем левую границу
            }
        }
        public void ShellSort(out int counter)
        {
            counter = 0;
            int j;
            int step = Items.Count / 2;
            while (step > 0)
            {
                for (int i = 0; i < (Items.Count - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (Items[j].key > Items[j + step].key))
                    {
                        Item tmp = Items[j];
                        Items[j] = Items[j + step];
                        Items[j + step] = tmp;
                        j -= step;
                        counter++;
                    }
                }
                step = step / 2;
            }
        }
        public int BinarySearch(int key, out int counter)
        {
            counter = 0;
            int first = 0;
            int last = Items.Count;
            while (first < last)
            {
                int mid = first + (last - first) / 2;
                if (key <= Items[mid].key)
                {
                    last = mid;
                }
                else
                {
                    first = mid + 1;
                }
                counter++;
            }
            if (Items[last].key == key)
            {
                return last;
            }
            else
            {
                return -1;
            }
        }
        public int InterpolationSearch(int key, out int counter)
        {
            counter = 0;
            int mid;
            int left = 0;
            int right = Items.Count - 1;
            while (Items[left].key < key && Items[left].key > key)
            {
                mid = left + ((key - Items[left].key) * (right - left)) / (Items[right].key - Items[left].key);

                if (Items[mid].key < key)
                {
                    left = mid + 1;
                }
                else if (Items[mid].key > key)
                {
                    right = mid - 1;
                }
                else
                {
                    return mid;
                }
                counter++;
            }

            if (Items[left].key == key)
            {
                return left;
            }
            else if (Items[right].key == key)
            {
                return right;
            }
            else
            {
                return -1;
            }
        }
        public int LinearSearch(int key, out int counter)
        {
            counter = 0;
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].key==key)
                {
                    return i;
                }
                counter++;
            }
            return -1;
        }
        public int FastLinearSearch(int key, out int counter)
        {
            counter = 0;
            int i = 0;
            while (i<Items.Count && Items[i].key!=key)
            {
                i++;
                counter++;
            }
            if (i != Items.Count)
            {
                return i;
            }
            else return -1;
        }
        public int SuperFastLinearSearch(int key, out int counter)
        {
            counter = 0;
            int i = 0;
            while (i<Items.Count)
            {
                if (Items[i].key==key)
                {
                    return i;
                }
                else if (Items[i+1].key==key)
                {
                    return i+1;
                }
                else if(Items[i+2].key==key)
                {
                    return i+2;
                }
                counter++;
                i += 3;
            }
            return -1;
        }
        public void Display(ref ListView listView)
        {
            listView.Clear();
            listView.View = View.Details;
            listView.Columns.Add("Ключ", listView.Width/2, HorizontalAlignment.Left);
            listView.Columns.Add("Значение", listView.Width/2, HorizontalAlignment.Left);
            foreach (Item i in Items)
            {
                listView.Items.Add(Convert.ToString(i.key)).SubItems.Add(i.value);
            }
        }
    }
}
