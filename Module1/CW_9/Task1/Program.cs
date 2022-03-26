using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();
            string path = @"C:\Users\user\RiderProjects\CW_9\Task1\File.txt";
            
            for (int i = 0; i < n; i++)
            {
                File.AppendAllText(path, rand.Next(10, 100) + " ");
            }
        }
    }
}