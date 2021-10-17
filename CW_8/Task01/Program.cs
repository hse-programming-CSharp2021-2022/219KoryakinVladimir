using System;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = "aeyuio";
            string input = Console.ReadLine();
            foreach (var str in input.Split(";"))
            {
                string[] words = str.Split();
                StringBuilder res = new StringBuilder("", 50);
                foreach (var word in words)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 0)
                        {
                            res.Append(word[i].ToString().ToUpper());
                        }
                        else
                        {
                            res.Append(word[i]);
                        }

                        if (g.Contains(word[i].ToString().ToLower()))
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine(res);
            }
        }
    }
}