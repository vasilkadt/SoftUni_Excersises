using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartamentPrice = 0;

            if (mounth == "May" || mounth == "October")
            {
                studioPrice = nights * 50;
                apartamentPrice = nights * 65;
                if (nights > 14)
                {
                    apartamentPrice -= apartamentPrice * 0.1;
                    studioPrice -= studioPrice * 0.3;
                }
                else if (nights > 7)
                {
                    studioPrice -= studioPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = nights * 75.20;
                apartamentPrice = nights * 68.70;
                if (nights > 14)
                {
                    apartamentPrice -= apartamentPrice * 0.1;
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else
            {
                studioPrice = nights * 76;
                apartamentPrice = nights * 77;
                if (nights > 14)
                {
                    apartamentPrice -= apartamentPrice * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
