using System;

namespace Task1
{
    public delegate double Calculate(double x);
    internal interface IFunction
    {
        double Function(double x);
    }

    class F : IFunction
    {
        private readonly Calculate _calculate;
        public F(Calculate calc)
        {
            _calculate = calc;
        }
        public double Function(double x) => _calculate(x);
    }

    class G
    {
        F _f1, _f2;
        public G(F f1, F f2)
        {
            _f1 = f1;
            _f2 = f2;
        }
        public double GF(double x0) => _f1.Function(_f2.Function(x0));
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            F a = new(x => x * x - 4);
            F b = new(x => Math.Sin(x));

            G g = new(a, b);

            for (double i = 0; i <= Math.PI; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):F4}");
            }
        }
    }
}