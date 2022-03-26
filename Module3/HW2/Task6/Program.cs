using System;

namespace Task6
{
    class Plant
    {
        private double _growth;
        private double _photosensitivity;
        private double _frostresistance;

        public double Growth { get => _growth; set {_growth = value;} }
        public double Photosensitivity { get => _photosensitivity; set { _photosensitivity = Math.Clamp(value, 0, 100); } }
        public double Frostresistance { get => _frostresistance; set { _frostresistance = Math.Clamp(value, 0, 100); } }

        public Plant(double g, double p, double f)
        {
            Growth = g;
            Photosensitivity = p;
            Frostresistance = f;
        }

        public override string ToString()
        {
            return $"{Growth:f2} {Photosensitivity:f2} {Frostresistance:f2}";
        }
    }

    class Program
    {
        public static int SortByPhsens(Plant a, Plant b)
        {
            if (a.Photosensitivity % 2 == 1 && b.Photosensitivity % 2 == 0) return 1;
            return -1;
        }

        static void Main(string[] args)
        {
            Random rand = new();

            int n = int.Parse(Console.ReadLine());
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                plants[i] = new(rand.NextDouble() * 75 + 25, rand.NextDouble() * 100, rand.NextDouble() * 80);
            }

            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();

            Array.Sort(plants, delegate (Plant a, Plant b)
            {
                if (a.Growth < b.Growth) return 1;
                return -1;
            });
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();

            Array.Sort(plants, (a, b) =>
            {
                if (a.Frostresistance > b.Frostresistance) return 1;
                return -1;
            });
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();

            Array.Sort(plants, SortByPhsens);
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();

            Array.ConvertAll(plants, (t) => 
            { 
                if (((int)t.Frostresistance) % 2 == 0)
                {
                    t.Frostresistance /= 3;
                } else
                {
                    t.Frostresistance /= 2;
                }
                return t;
            });
            Array.ForEach(plants, (t) => Console.WriteLine(t));
            Console.WriteLine();
        }
    }
}