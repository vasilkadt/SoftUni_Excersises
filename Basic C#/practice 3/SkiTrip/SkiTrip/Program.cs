using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string grade = Console.ReadLine();
            double sum = 0;
            int nights = days - 1;
            int firstSum = 0;
            if (days >= 0 && days <= 365 && (grade == "positive" || grade == "negative"))
            {
                if (place == "room for one person")
                {
                    firstSum = nights * 18;
                    sum = nights * 18;
                }
                else if (place == "apartment")
                {
                    firstSum = nights * 35;
                    if (days < 10)
                        sum = 25 * nights * 0.7;
                    if (days >= 10 && days <= 15)
                        sum = 25 * nights * 0.65;
                    if (days > 15)
                        sum = 25 * nights * 0.5;

                }
                else if (place == "president apartment")
                {
                    if (days < 10)
                        sum = 35 * nights * 0.9;
                    if (days >= 10 && days <= 15)
                        sum = 35 * nights * 0.85;
                    if (days > 15)
                        sum = 35 * nights * 0.8;

                }
                if (grade == "positive")
                    sum += 0.25 * sum;
                else if (grade == "negative")
                    sum *= 0.9;
                Console.WriteLine($"{sum:F2}");
            }
        }

    }
}