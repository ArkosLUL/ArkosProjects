using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Album
    {
        public int Year { get; set; }

        public string Name { get; set; }

        public Album(int year, string name)
        {
            this.Year = year;
            this.Name = name;
        }
    }

    class AlbumsCollection
    {
        private List<Album> AlbumList;

        public void AddAlbum(params Album[] l)
        {
            if (AlbumList == null)
            {
                AlbumList = new List<Album>();
            }
            AlbumList.AddRange(l);
        }

        public override string ToString()
        {
            string te = "";
            foreach (Album al in AlbumList)
            {
                te += al.Name;
                te += "  ";
                te += al.Year;
                te += "\n";
            }
            return te;
        }

        public bool IsEmpty()
        {

            if (AlbumList.Count == 0)
            {
                return false;
            }

            else return true;
        }

        public void ShakerSort()
        {

            int left = 0;
            int right = AlbumList.Count() - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (AlbumList[i].Year > AlbumList[i + 1].Year)
                    {
                        Album b = AlbumList[i];
                        AlbumList[i] = AlbumList[i + 1];
                        AlbumList[i + 1] = b;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (AlbumList[i + 1].Year < AlbumList[i].Year)
                    {
                        Album b = AlbumList[i];
                        AlbumList[i] = AlbumList[i + 1];
                        AlbumList[i + 1] = b;
                    }
                }
                left++;
            }
        }

        public void CombSort()
        {
            double gap = AlbumList.Count;
            bool swaps = true;

            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;

                if (gap < 1)
                    gap = 1;

                int i = 0;
                swaps = false;

                while (i + gap < AlbumList.Count)
                {
                    int igap = i + (int)gap;

                    if (AlbumList[i].Year > AlbumList[igap].Year)
                    {
                        Album temp = AlbumList[i];
                        AlbumList[i] = AlbumList[igap];
                        AlbumList[igap] = temp;
                        swaps = true;
                    }

                    ++i;
                }
            }
        }

        public void ShellSort()
        {
            int n = AlbumList.Count;
            int gap = n / 2;
            Album temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = AlbumList[j];

                    while (j - gap >= 0 && temp.Year < AlbumList[j - gap].Year)
                    {
                        AlbumList[j] = AlbumList[j - gap];
                        j = j - gap;
                    }

                    AlbumList[j] = temp;
                }

                gap = gap / 2;
            }
        }

        public void InsertionSort()
        {
            for (int i = 1; i < AlbumList.Count; i++)
            {
                int j;
                Album buf = AlbumList[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (AlbumList[j].Year < buf.Year)
                        break;

                    AlbumList[j + 1] = AlbumList[j];
                }
                AlbumList[j + 1] = buf;
            }
        }

        public void Quicksort()
        {
            if (AlbumList.Count > 1) Quicksort(0, AlbumList.Count - 1);
        }

        private void Quicksort(int left, int right)
        {
            if (left == right) return;
            int i = left + 1;
            int j = right;
            Album pivot = AlbumList[left];

            while (i < j)
            {
                if (AlbumList[i].Year <= pivot.Year) i++;
                else if (AlbumList[j].Year > pivot.Year) j--;
                else
                {
                    Album m = AlbumList[i];
                    AlbumList[i] = AlbumList[j];
                    AlbumList[j] = m;
                }
            }

            if (AlbumList[j].Year <= pivot.Year)
            {
                Album m = AlbumList[left];
                AlbumList[left] = AlbumList[right];
                AlbumList[right] = m;
                Quicksort(left, right - 1);
            }
            else
            {
                Quicksort(left, i - 1);
                Quicksort(i, right);
            }
        }

        public int FibonacciSeries(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0;
            if (n == 1) return 1;

            for (int i = 2; i <= n; i++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }
    }
}
