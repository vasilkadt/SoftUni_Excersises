using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Price(product, quantity);
        }

        static void Price(string product, int quantity)
        {
            double sum = 0;
            if (product == "coffee")
            { sum += quantity * 1.5; }
            else if (product == "water")
            { sum += quantity * 1.0; }
            else if (product == "coke")
            { sum += quantity * 1.4; }
            else if (product == "snacks")
            { sum += quantity * 2.0; }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
