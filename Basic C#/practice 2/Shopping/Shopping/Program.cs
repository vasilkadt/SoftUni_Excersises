using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int procesors = int.Parse(Console.ReadLine());
            int RAMs = int.Parse(Console.ReadLine());

            double videocardsPrice = videocards * 250;
            double oneProcesorPrice = videocardsPrice * 0.35;
            double sumOfAllProcesors = oneProcesorPrice * procesors;
            double oneRAMPrice = videocardsPrice * 0.1;
            double sumOfAllRAMs = oneRAMPrice * RAMs;
            double totalPrice = videocardsPrice + sumOfAllProcesors + sumOfAllRAMs;

            if(videocards > procesors)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }

            if(budget >= totalPrice)
            {
                Console.WriteLine($"You have {(budget-totalPrice):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget-totalPrice):f2} leva more!");
            }
        }
    }
}
