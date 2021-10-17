using System;

namespace Task1
{
    class Program
    {
        static void PrintMas(char[] m)
        {
            foreach (var e in m)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            char[] mas = new char[k];
            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                mas[i] = (char) random.Next('A', 'Z' + 1);
            }
            PrintMas(mas);

            char[] copy = new char[k];
            Array.Copy(mas, copy, k);
            Array.Sort(copy);
            PrintMas(copy);
            Array.Reverse(copy);
            PrintMas(copy);
        }
    }
}