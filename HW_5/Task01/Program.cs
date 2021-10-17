using System;

namespace Task01
{
    class Program
    {
        static int Transform(int[] a)
        {
            int k = a.Length;
            int ind = 0;
            while (ind < k - 1)
            {
                if ((a[ind] + a[ind + 1]) % 3 == 0)
                {
                    a[ind] = a[ind] * a[ind + 1];
                    for (int i = ind + 1; i < k - 1; i++)
                    {
                        a[i] = a[i + 1];
                    }

                    k -= 1;
                }
                ind += 1;
            }

            return k;
        }

        static void Main(string[] args)
        {
            int[] mas = new int[] {1, 2, 3, 4, 5};
            int len = Transform(mas);
            for (int i = 0; i < len; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
    }
}