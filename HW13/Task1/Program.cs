using System;
using System.Collections;

namespace Task1
{
    class Fibbonacci : IEnumerable
    {
        int f0 = 1, f1 = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
        public IEnumerable NameEnumerator(int n)
        {
            int f0 = 1, f1 = 1;
            for (int i = 0; i < n; ++i)
            {
                yield return f0;
                int c = f0;
                f0 = f1;
                f1 += c;
            }
        }
    }
    class TriangleNums : IEnumerable
    {
        int num = 1;
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; ++i)
            {
                yield return num;
                num += i + 2;
            }
        }
        public IEnumerable NameEnumerator(int num)
        {
            for (int i = 0; i < num; ++i)
            {
                yield return this.num;
                this.num += i + 2;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Fibbonacci fibbonacci = new Fibbonacci();
            TriangleNums triangleNums = new TriangleNums();
            int[] res = new int[10];
            int i = 0;
            foreach (var e in fibbonacci.NameEnumerator(10))
            {
                Console.WriteLine(e);
                res[i++] = (int)e;
            }
            i = 0;
            foreach (var e in triangleNums.NameEnumerator(10))
            {
                Console.WriteLine(e);
                res[i++] += (int)e;
            }
            foreach (var e in res)
            {
                Console.WriteLine(e);
            }
        }
    }
}