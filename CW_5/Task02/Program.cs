using System;

namespace Task02
{
    class Program
    {
        static double Sum(int n)
        {
            double res = 0;
            for (int i = 1; i <= n; i++)
            {
                res += (i + 0.3) / (3 * i * i + 5);
            }

            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(int.Parse(Console.ReadLine())));
        }
    }
}