using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U = double.Parse(Console.ReadLine());
            double R = double.Parse(Console.ReadLine());
            if (R.Equals(0))
                Console.WriteLine("Incorrect input: R = 0");
            else
                Console.WriteLine("I = " + (U / R) + "\n" + "P = " + (U * U / R));
            Console.ReadLine();
        }
    }
}