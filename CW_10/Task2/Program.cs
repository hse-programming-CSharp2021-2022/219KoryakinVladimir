using System;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex reg = new Regex("^....$");
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