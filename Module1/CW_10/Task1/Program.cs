using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static int SumOfDigits(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a /= 10;
            }

            return sum;
        }

        static int MaxDigit(int a)
        {
            int max = 0;
            while (a > 0)
            {
                int c = a % 10;
                a /= 10;
                if (c > max)
                {
                    max = c;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random r = new Random();
            int[] mas = new int[n];
            int sum4 = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 10000);
                Console.Write(mas[i] + " ");
            }
            Array.Sort(mas);
            
            var select1 = (from e in mas
                where (e.ToString().Length == 2) && (e % 3 == 0)
                select e);
            
            var select2 = (from e in mas
                where (e.ToString().ToCharArray().Reverse().ToString() == e.ToString())
                select e);

            var select3 = (from e in mas
                orderby SumOfDigits(e)
                select e);
            var select4 = (from e in mas
                where e.ToString().Length == 4
                select e);
            var select5 = (from e in mas
                where e.ToString().Length == 2
                select e);
            var select6 = (from e in mas
                select MaxDigit(e));
            
            Console.WriteLine();
            foreach (var i in select3)
            {
                Console.Write(i + " ");
            }
        }
    }
}