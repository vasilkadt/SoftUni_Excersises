using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double totalSum = 0.0;
            if (flower == "Roses")
            {
                totalSum = number * 5.0;
                if (number > 80)
                { totalSum = totalSum - totalSum * 0.1; }
            }
            else if (flower == "Dahlias")
            {
                totalSum = number * 3.8;
                if (number > 90)
                { totalSum = totalSum - totalSum * 0.15; }
            }
            else if (flower == "Tulips")
            {
                totalSum = number * 2.8;
                if (number > 80)
                { totalSum = totalSum - totalSum * 0.15; }
            }
            else if (flower == "Narcissus")
            {
                totalSum = number * 3.0;
                if (number < 120)
                { totalSum = totalSum + totalSum * 0.15; }
            }
            else if (flower == "Gladiolus")
            {
                totalSum = number * 2.5;
                if (number < 80)
                { totalSum = totalSum + totalSum * 0.2; }
            }
            if (budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flower} and {(budget - totalSum):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalSum - budget):f2} leva more.");
            }
        }
    }
}
