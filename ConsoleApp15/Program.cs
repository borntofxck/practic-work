using System.Collections.Generic;
using System;
using System.Linq;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();

        }

        private static void Ex3()
        {
            double[] A = new double[10] { 4, 0, -2, 2, -7, 8, 54, -19, 9, -10 };
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0)
                {
                    double x = A[i];
                    A[i] = Math.Pow(A[i], 2);
                }
                if (A[i] > 0)
                {
                    A[i] = A[i] / 2;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($" {A[i]}");
            }
            Console.WriteLine();
        }

        private static void Ex2()
        {
            int[] A = new int[10] { 0, 3, 6, 12, 6, 18, 2, 5, 7, 12 };
            int max = A.Max();
            int min = A.Min();
            int indexmax = Array.IndexOf(A, max);
            int indexmin = Array.IndexOf(A, min);
            float sum = 0;
            float count = 0;
            for (int i = indexmin + 1; i < indexmax; i++)
            {
                count++;
                sum += A[i];
            }
            Console.WriteLine(sum);
            float arifm = sum / count;
            Console.WriteLine(arifm);
        }

        private static void Ex1()
        {
            int[] A = new int[10] { 3, -2, 4, -10, 1, 5, -6, 7, 8, 9 };
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            int product = 1;
            foreach (int i in A)
            {
                if (i < 0)
                {
                    list.Add(i);
                }
                if (i > 0)
                {
                    list2.Add(i);
                }
            }
            int indexFirst = Array.IndexOf(A, list[0]);
            int indexLast = Array.IndexOf(A, list2[list2.Count - 1]);
            for (int i = indexFirst + 1; i < indexLast; i++)
            {
                product = product * A[i];
            }
            Console.WriteLine(product);
        }
    }
}
