using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string a = Console.ReadLine();
            while (!int.TryParse(a, out int c))
            {
                Console.WriteLine("Ви ввели не число. Спробуйте ще раз:");
                a = Console.ReadLine();
            }
            Console.WriteLine("Ви ввели число {0}", a);
        }
    }
}