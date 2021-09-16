using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine((a + b > c) && (a + c > b) && (c + b > a) ? "Треугольник с такими сторонами существует!" : "Треуголника с такими сторонами не существует");
        }
    }
}