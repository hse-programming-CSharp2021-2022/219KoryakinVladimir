using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(a * a + b * b));
            Console.ReadLine();
        }
    }
}