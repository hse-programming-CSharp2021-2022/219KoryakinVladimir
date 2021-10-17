using System;

namespace Task01
{
    class Program
    {
        static int SumOfDigits(int a, int b)
        {
            int sum1 = 0;
            while (a > 0)
            {
                sum1 += a % 10;
                a /= 10;
            }
            int sum2 = 0;
            while (b > 0)
            {
                sum2 += b % 10;
                b /= 10;
            }

            if (sum1 > sum2)
                return 1;
            else
                return -1;
        }
        static int OddEven(int a, int b)
        {
            if (a % 2 > b % 2)
                return -1;
            else if (a % 2 < b % 2)
                return 1;
            else
                return 0;
        }
        
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rand.Next(0, 1000);
            }
            Array.Sort(mas, OddEven);
            Array.ForEach(mas, e => Console.Write(e + " "));
            Console.WriteLine();
            Array.Sort(mas);
            Array.ForEach(mas, e => Console.Write(e + " "));
            Console.WriteLine();
            Array.Sort(mas, SumOfDigits);
            Array.ForEach(mas, e => Console.Write(e + " "));
        }
    }
}