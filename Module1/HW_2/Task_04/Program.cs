using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.WriteLine(n%10);
                n /= 10;
            }
        }
    }
}