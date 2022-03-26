using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = (n % 100) / 10;
            int c = n % 10;
            int max = 100 * Math.Max(Math.Max(a, b), c) + Math.Min(Math.Min(a, b), c) +
                      + 10 * (a+b+c - Math.Max(Math.Max(a, b), c) - Math.Min(Math.Min(a, b), c));
            Console.WriteLine(max);
        }
    }
}