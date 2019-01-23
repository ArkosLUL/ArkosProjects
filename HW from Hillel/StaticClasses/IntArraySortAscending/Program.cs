using System;
using System.Collections.Generic;

namespace IntArraySortAscending
{
    static class Extension
    {
        public static int[] AscendingSort(this int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 1, 0, 9, 15, 6 };
            numbers=numbers.AscendingSort();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
