using System;

namespace Task01
{
    class Program
    {
        static void Function2(bool p, bool q, out bool c)
        {
            c = (!(p & q) & !(p | !q));
        }
        static bool Function1(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }
        static void Main(string[] args)
        {
            bool res;
            bool a = bool.Parse(Console.ReadLine());
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine(Function1(a, b));
            Function2(a, b, out res);
            Console.WriteLine(res);
        }
    }
}