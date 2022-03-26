using System;

namespace Task02
{
    class Program
    {
        static void For()
        {
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i * i);
            }
        }

        static void While()
        {
            int n = 2;
            while (n <= 20)
            {
                Console.WriteLine(n * n);
                n += 2;
            }
        }
        static void DoWhile()
        {
            int n = 2;
            do
            {
                Console.WriteLine(n * n);
                n += 2;
            } while (n <= 20);
        }
        static void Main(string[] args)
        {
            For();
            While();
            DoWhile();
        }
    }
}