using System;

namespace Task04
{
    class Program
    {
        static void Reverse(int a)
        {
            if (a == 0)
                Console.WriteLine(0);
            while (a > 0)
            {
                Console.Write(a % 10);
                a /= 10;
            }
        }
        static void Main(string[] args)
        {
            Reverse(int.Parse(Console.ReadLine()));
        }
    }
}