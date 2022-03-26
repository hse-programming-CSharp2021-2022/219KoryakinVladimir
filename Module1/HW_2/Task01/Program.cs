using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int x2 = 0;
            for (int i = 0; i < x; i++)
            {
                x2 += x;
            }
            int x3 = 0;
            for (int i = 0; i < x; i++)
            {
                x3 += x2;
            }
            int x4 = 0;
            for (int i = 0; i < x; i++)
            {
                x4 += x3;
            }

            Console.Write(x4+x4+x4+x4+x4+x4+x4+x4+x4+x4+x4+x4 + x3+x3+x3+x3+x3+x3+x3+x3+x3 +
                            + (-x2-x2-x2) + x+x - 4);
        }
    }
}