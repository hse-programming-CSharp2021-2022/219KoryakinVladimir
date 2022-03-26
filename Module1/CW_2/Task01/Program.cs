using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse((Console.ReadLine()));
            Console.WriteLine((r * r * Math.PI).ToString("F3"));
            Console.WriteLine((2 * r * Math.PI).ToString("F3"));
        }
    }
}