using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Так как в условии просят вычислить корни квадратного уравнения, я не рассматриваю случай a=0(считаю уравнение квадратным)
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            Console.WriteLine(d < 0 ? "There's no real equation solutions!" : (d == 0 ? (-b/(2*a)) : (-b+Math.Sqrt(d))/(2*a) + " " + (-b-Math.Sqrt(d))/(2*a)));
        }
    }
}