using System;

namespace MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double partyPrice = double.Parse(Console.ReadLine());
            int loveLetters = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keychains = int.Parse(Console.ReadLine());
            int cartoons = int.Parse(Console.ReadLine());
            int lucks = int.Parse(Console.ReadLine());

            double loveLettersPrice = loveLetters * 0.6;
            double rosesPrice = roses * 7.2;
            double keychainsPrice = keychains * 3.6;
            double cartoonsPrice = cartoons * 18.2;
            double lucksPrice = lucks * 22.0;

            double totalSum = loveLettersPrice + rosesPrice + keychainsPrice + cartoonsPrice + lucksPrice;
            int articuls = loveLetters + roses + keychains + cartoons + lucks;
            if (articuls >= 25)
            {
                totalSum -= 0.35 * totalSum;
            }
            totalSum -= 0.10 * totalSum;
            if (totalSum >= partyPrice)
            {
                Console.WriteLine($"Yes! {(totalSum-partyPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(partyPrice-totalSum):f2} lv needed.");
            }
        }
    }
}
