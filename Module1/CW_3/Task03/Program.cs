using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case < 4:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case < 6:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case < 8:
                    Console.WriteLine("Хорошо");
                    break;
                case <= 10:
                    Console.WriteLine("Отлично");
                    break;
            }
        }
    }
}