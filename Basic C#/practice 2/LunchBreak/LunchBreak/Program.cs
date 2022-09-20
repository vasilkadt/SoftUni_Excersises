using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double lunchTime = lunchBreak / 8.0;
            double relaxTime = lunchBreak / 4.0;
            double leftTime = lunchBreak - lunchTime - relaxTime;
            double difference = leftTime - episodeTime;

            if (difference >= 0)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
