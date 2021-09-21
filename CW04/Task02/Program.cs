﻿using System;

namespace Task02
{
    class Program
    {
        static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return A(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return A(m - 1, A(m, n - 1));
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(A(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
    }
}