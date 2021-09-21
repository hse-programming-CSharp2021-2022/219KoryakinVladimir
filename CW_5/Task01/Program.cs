using System;

namespace Task01
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            string strN = number.ToString(); 
            sumEven = 0;
            sumOdd = 0;
            for (int i = 0; i < strN.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sumOdd += uint.Parse(strN[i].ToString());
                }
                else
                {
                    sumEven += uint.Parse(strN[i].ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            uint a = uint.Parse(Console.ReadLine());
            uint s1, s2;
            Sums(a, out s1, out s2);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}