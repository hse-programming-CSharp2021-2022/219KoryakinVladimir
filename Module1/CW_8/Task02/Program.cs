using System;
using System.Linq;
using System.Text;

namespace Task02
{
    class Program
    {
        static string ConvertHex2Bin(string HexNumber)
        {
            StringBuilder binaryNumber = new StringBuilder("", 1000);
            foreach (var digit in HexNumber)
            {
                int n;
                if (!int.TryParse(digit.ToString(), out n))
                {
                    switch (digit)
                    {
                        case 'A':
                            n = 10;
                            break;
                        case 'B':
                            n = 11;
                            break;
                        case 'C':
                            n = 12;
                            break;
                        case 'D':
                            n = 13;
                            break;
                        case 'E':
                            n = 14;
                            break;
                        case 'F':
                            n = 15;
                            break;
                    }
                }

                StringBuilder d = new StringBuilder("", 50);
                for (int i = 0; i < 4; i++)
                {
                    d.Append((n % 2).ToString());
                    n /= 2;
                }

                char[] cd = d.ToString().ToCharArray();
                Array.Reverse(cd);
                binaryNumber.Append(new string(cd));
            }

            return binaryNumber.ToString();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin(Console.ReadLine()));
        }
    }
}