using System;

namespace Task3_ConsoleApp
{
    class Converter
    {
        private decimal _usdHrn;
        private decimal _euroHrn;

        public Converter(decimal eur, decimal usd)
        {
            while (eur<=0 || usd <=0)
            {
                Console.WriteLine("Wrong currency rate! Enter again: \n Euro:");
                string temp = Console.ReadLine();
                if (decimal.TryParse(temp, out _) && Convert.ToDecimal(temp) > 0) eur = Convert.ToDecimal(temp);
                Console.WriteLine("Dollar:");
                 temp = Console.ReadLine();
                if (decimal.TryParse(temp, out _) && Convert.ToDecimal(temp) > 0) usd = Convert.ToDecimal(temp);
            }
            _euroHrn = eur;
            _usdHrn = usd;
        }
        public void ConvertValue()
        {
            Console.WriteLine("Hi! How much money do you want to exchange?");
            string amount = Console.ReadLine();
            
            while (!int.TryParse(amount, out _) && Convert.ToInt32(amount) <= 0)
            {
                Console.WriteLine("Something went wrong. Try again:");
                amount = Console.ReadLine();
            }

            decimal value = Convert.ToDecimal(amount);
            while (value <= 0)
            {
                Console.WriteLine("Wrong value! Try again:");
                string temp = Console.ReadLine();
                if (decimal.TryParse(temp, out _) && Convert.ToDecimal(temp) > 0) value = Convert.ToDecimal(temp);
            }
            Console.WriteLine("To exchange from hryvnias to euros, press 0");
            Console.WriteLine("To exchange from hryvnias to dollars, press 1");
            Console.WriteLine("To exchange from euros to hryvnias, press 2");
            Console.WriteLine("To exchange from dollars to hryvnias, press 3");
            Console.WriteLine("To exit, press 4");
            while (true)
            {
                    string choice = Console.ReadLine();
                    if (choice == "0")
                        Console.WriteLine("{0} hryvnias to euro will be {1}", value, Convert.ToInt32(value) / _euroHrn);
                    if (choice == "1")
                        Console.WriteLine("{0} hryvnias to usd will be {1}", value, Convert.ToInt32(value) / _usdHrn);
                    if (choice == "2")
                        Console.WriteLine("{0} hryvnias to euro will be {1}", value, Convert.ToInt32(value) * _euroHrn);
                    if (choice == "3")
                        Console.WriteLine("{0} hryvnias to usd will be {1}", value, Convert.ToInt32(value) * _usdHrn);
                    if (choice == "4")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Converter fst = new Converter(37, 38);
            
            fst.ConvertValue();
        }
    }
}