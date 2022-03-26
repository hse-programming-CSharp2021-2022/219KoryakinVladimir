using System;

namespace Task2
{
    class Program
    {
        static void PrintMas(int[] m)
        {
            foreach (var e in m)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] mas = new int[99];
            int[] gen = new int[100];
            for (int i = 0; i < 100; i++)
            {
                gen[i] = i + 1;
            }

            Random rand = new Random();
            int index = 0;
            while (index < 99)
            {
                int current_index = rand.Next(index, 100);
                mas[index] = gen[current_index];
                gen[current_index] = gen[index];
                index += 1;
            }
            
            PrintMas(mas);
            int sum = 0;
            
            foreach (var el in mas)
            {
                sum += el;
            }
            
            Console.WriteLine(101*100/2 - sum);
        }
    }
}