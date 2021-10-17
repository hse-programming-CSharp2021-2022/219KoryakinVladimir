using System;

namespace Task3
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
            int[] mas = new int[100];
            int[] gen = new int[100];
            for (int i = 0; i < 100; i++)
            {
                gen[i] = i + 1;
            }

            Random rand = new Random();
            int index = 0;
            while (index < 100)
            {
                int current_index = rand.Next(index, 100);
                mas[index] = gen[current_index];
                gen[current_index] = gen[index];
                index += 1;
            }

            int i1 = rand.Next(0, 99);
            int i2 = rand.Next(0, 99);
            while (i1 == i2)
            {
                i1 = rand.Next(0, 99);
                i2 = rand.Next(0, 99);
            }

            mas[i2] = mas[i1];
            PrintMas(mas);
            int[] check = new int[100];
            foreach (var e in mas)
            {
                check[e - 1] += 1;
                if (check[e - 1] == 2)
                {
                    Console.WriteLine(e);
                    break;
                }
            }
        }
    }
}