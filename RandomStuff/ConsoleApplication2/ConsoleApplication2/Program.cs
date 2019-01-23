using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 5);
                }
            }
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("FUCK YOU LETHER MAN");
            Transp(arr);
            for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(arr[i, j] + "\t");
                        }
                        Console.WriteLine();
                  }
            Console.WriteLine("FUCK YOU LETHER MAN");
            Transp1(arr, n);
            Transp1(arr, n);
            Console.WriteLine("FUCK YOU LETHER MAN");
            Console.WriteLine("FUCK YOU LETHER MAN");
            Console.WriteLine("FUCK YOU LETHER MAN");
            Console.WriteLine(Sum(arr));
            Console.WriteLine(MinCount(arr));

            //Console.WriteLine("FUCK YOU LETHER MAN");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
        }
        static int MinCount(int [,] a)
        {
            int count=0, min=a[0,0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                        count = 0;
                    }
                    if (min == a[i, j])
                        count++;
                }
            }
            return count;
        }
        static int Sum(int[,] a)
        {
            int sum=0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                
                    sum += a[i, i];   
                
            }
            return sum;
        }
        static void Transp1(int[,] a, int n)
        {
            int temp;
            for (int i = 0; i < n ; i++)
            {
                for (int j = i; j < n ; j++)
                {
                    temp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Transp(int [,] arr)
        {
            int[,] arrnew = new int[arr.GetLength(0),arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arrnew[i, j] = arr[j, i];
                }

            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = arrnew[i,j];
                }

            }
        }
    }
}
