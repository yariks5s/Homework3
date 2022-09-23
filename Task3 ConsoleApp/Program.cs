using System;

namespace Task3_ConsoleApp
{
    class Converter
    {
        private double _HrnUsd;
        private double _HrnEuro;

        public Converter(double eur, double usd)
        {
            _HrnEuro = eur;
            _HrnUsd = usd;
        }
        public double ConvertToEuro(double hrn)
        {
            return hrn * _HrnEuro;
        }

        public double ConvertToUsd(double hrn)
        {
            return hrn * _HrnUsd;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Converter fst = new Converter(0.028, 0.027);
            Console.WriteLine("{0} hryvnias to euro will be {1}", 55, fst.ConvertToEuro(55));
            Console.WriteLine("{0} hryvnias to usd will be {1}", 55, fst.ConvertToUsd(55));
        }
    }
}