using System;
using System.Text.RegularExpressions;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex("a$");
            Console.WriteLine();
            foreach (var word in (input.Split()))
            {
                if (reg.IsMatch(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}