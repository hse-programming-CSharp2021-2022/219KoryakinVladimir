using System;

namespace Task02
{
    class Program
    {
        public static void PrintNumbers(string a)
        {
            int p = (int) Math.Pow(10, a.Length - 1);
            int l = a.Length;
            for (int i = 0; i < l; i++)
            { 
                Console.WriteLine(int.Parse(a) / p);
                a = (int.Parse(a) % p).ToString();
                p /= 10;
            }
        } 
        static void Main(string[] args)
        {
            PrintNumbers(Console.ReadLine());
        }
    }
}