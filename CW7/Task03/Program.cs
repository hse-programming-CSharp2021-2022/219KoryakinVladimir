using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(1000, 10000);
            }
            Array.ForEach(mas, e => Console.Write(e + " "));
            Console.WriteLine();
            Console.WriteLine();
            Array.ForEach(
                Array.FindAll(mas, a => (a / 1000 == a % 10) && ((a % 1000) / 100 == (a % 100) / 10)), 
                e => Console.Write(e + " "));
        }
    }
}