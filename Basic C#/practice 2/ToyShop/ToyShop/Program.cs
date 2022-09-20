using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzlesNumber = int.Parse(Console.ReadLine());
            int dollsNumber = int.Parse(Console.ReadLine());
            int teddyBearsNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());
            int countToys = puzzlesNumber + dollsNumber + teddyBearsNumber + minionsNumber + trucksNumber;

            double puzzlePrice = puzzlesNumber * 2.6;
            double dollsPrice = dollsNumber * 3.0;
            double teddyBearPrice = teddyBearsNumber * 4.1;
            double minionsPrice = minionsNumber * 8.2;
            double trucksPrice = trucksNumber * 2.0;

            double profit = puzzlePrice + dollsPrice + teddyBearPrice + minionsPrice + trucksPrice;
            if(countToys >= 50)
            {
                profit = profit - profit * 0.25;
            }
            profit = profit - profit * 0.1;
            double difference = profit - vacationPrice;
            if(vacationPrice <= profit)
            {
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(difference):f2} lv needed.");
            }
        }
    }
}
