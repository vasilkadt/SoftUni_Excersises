using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)(1.31 * pounds);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
