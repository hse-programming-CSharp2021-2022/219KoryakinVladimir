using System;

namespace Task04
{
    class Program
    {
        static int CompareByLength(int[] a, int[]b)
        {
            if (a.GetLength(0) < b.GetLength(0))
                return 1;
            else
            {
                return -1;
            }
        }
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int[][] mas = new int[n][];
            for (int i = 0; i < n; i++)
            {
                mas[i] = new int[rand.Next(5, 16)];
                for (int j = 0; j < mas[i].GetLength(0); j++)
                {
                    mas[i][j] = rand.Next(-10, 11);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mas[i].GetLength(0); j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Array.Sort(mas[i]);
                Array.Reverse(mas[i]);
            }
            
            Array.Sort(mas, CompareByLength);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < mas[i].GetLength(0); j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}