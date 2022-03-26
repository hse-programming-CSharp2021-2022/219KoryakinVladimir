using System;

namespace Task3
{
    delegate double DelegateConvertTemperature(double temperature);
    static class TemperatureConverterImp
    {
        public static double FromFahrenheit(double f) => (f - 32) * 5 / 9;
        public static double ToFahrenheit(double c) => c * 9 / 5 + 32;
    }
    static class StaticTempConverters
    {
        public static double CToK(double c) => c + 273.15;
        public static double CFromK(double k) => k - 273.15;
        
        public static double CToR(double c) => (c + 273.15) * 9 / 5;
        public static double CFromR(double r) => (r - 491.67) * 5 / 9;
        
        public static double ToFa(double c) => c * 4 / 5;
        public static double FromReomur(double re) => re * 5 / 4;
    }

    class Program
    {
        static void Main(string[] args)
        {
            DelegateConvertTemperature temp1 = new DelegateConvertTemperature(TemperatureConverterImp.FromFahrenheit);
            DelegateConvertTemperature temp2 = new DelegateConvertTemperature(TemperatureConverterImp.ToFahrenheit);
            DelegateConvertTemperature temp3 = new DelegateConvertTemperature(StaticTempConverters.CToK);
            DelegateConvertTemperature temp4 = new DelegateConvertTemperature(StaticTempConverters.CFromR);
            DelegateConvertTemperature temp5 = new DelegateConvertTemperature(StaticTempConverters.CToR);
            
            Console.WriteLine(temp1(123));
            Console.WriteLine(temp2(0.5));
            
            DelegateConvertTemperature[] dels = new DelegateConvertTemperature[] {temp2, temp3, temp4, temp5};

            int c = int.Parse(Console.ReadLine());
            
            foreach (var del in dels)
            {
                Console.WriteLine(del.Method.Name + " - " + del(c));
            }
        }
    }
}