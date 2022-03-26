using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            double[] mas = new double[n];
            int[] integer = new int[n];
            double[] rational = new double[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(-10, 10) + rand.NextDouble();
            }
            Array.ForEach(mas, e => Console.Write(e + " "));
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                rational[i] = mas[i] % 1;
                integer[i] = (int)(mas[i] / 1);
            }
            Array.Sort(integer);
            Array.Sort(rational);
            Array.ForEach(integer, e => Console.Write(e + " "));
            Console.WriteLine();
            Array.ForEach(rational, e => Console.Write(e + " "));
            Console.WriteLine();
        }
    }
}