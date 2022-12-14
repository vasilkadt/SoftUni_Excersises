using System;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double clothing = statists * clothingPrice;

            if(statists >= 150)
            {
                clothing = clothing - clothing * 0.1;
            }
            double neededMoney = decor + clothing;
            double difference = budget - neededMoney;

            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
        }
    }
}
