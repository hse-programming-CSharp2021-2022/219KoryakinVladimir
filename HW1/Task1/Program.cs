using System;

namespace Task1
{
    class Program
    {
        delegate int Cast(double number);
        static void Main(string[] args)
        {
            Cast castA = delegate (double n)
            {
                int r = (int)n;
                return r % 2 == 0 ? r : r + 1;
            };
            Cast castB = delegate (double n)
            {
                return (int)Math.Log10(n) + 1;
            };
            Console.WriteLine(castA(3.3));
            Console.WriteLine(castB(3.3));
            Console.WriteLine(castA(158.91));
            Console.WriteLine(castB(158.91));
        }
    }
}
