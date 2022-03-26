using System;

namespace Task1
{
    struct Point
    {
        public double x { get; }
        public double y { get; }
        public double RadiusVectorLength { get; }
        public Point(double _x = 0, double _y = 0)
        {
            x = _x;
            y = _y;
            RadiusVectorLength = Math.Sqrt(x * x + y * y);
        }
        public static double Distance(Point p1, Point p2) => p1.Distance(p2);
        public double Distance(Point p) => Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        public override string ToString() => $"{{{x}, {y}}}";
    }

    struct Circle : IComparable
    {
        public readonly Point center;
        private double rad;

        public double Rad
        {
            get => rad;
        }

        public Circle(double x, double y, double radius)
        {
            center = new(x, y);
            rad = radius;
        }

        public override string ToString() => $"Center: {center}, radius {rad}";

        public int CompareTo(object obj)
        {
            if (obj.GetType() != typeof(Circle))
                return 1;
            else
            {
                Circle other = (Circle) obj;
                if (other.center.RadiusVectorLength * other.Rad < center.RadiusVectorLength * Rad)
                    return 1;
                else
                    return -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            Circle[] circles = new Circle[5];
            for (int i = 0; i < 5; i++)
                circles[i] = new(rnd.Next(-20, 21), rnd.Next(-20, 21), rnd.NextDouble() * 10);
            Array.Sort(circles);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(circles[i]);
            }
        }
    }
}