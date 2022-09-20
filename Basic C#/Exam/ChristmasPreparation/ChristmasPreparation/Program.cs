using System;

namespace ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int fabric = int.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            int decrease = int.Parse(Console.ReadLine());

            double paperPrice = paper * 5.8;
            double fabricPrice = fabric * 7.2;
            double gluePrice = glue * 1.2;
            double totalSum = paperPrice + fabricPrice + gluePrice;
            totalSum -= ((double)decrease / 100) * totalSum;
            Console.WriteLine($"{totalSum:f3}");
        }
    }
}
