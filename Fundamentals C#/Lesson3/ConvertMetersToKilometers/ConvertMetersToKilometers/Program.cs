using System;

namespace ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            decimal km = (decimal)(m / 1000.0);
            Console.WriteLine($"{km:f2}");
        }
    }
}
