using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    price = 8.45;
                }
                else if (groupType == "Business")
                {
                    price = 10.90;
                }
                else if (groupType == "Regular")
                {
                    price = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    price = 9.80;
                }
                else if (groupType == "Business")
                {
                    price = 15.60;
                }
                else if (groupType == "Regular")
                {
                    price = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    price = 10.46;
                }
                else if (groupType == "Business")
                {
                    price = 16;
                }
                else if (groupType == "Regular")
                {
                    price = 22.50;
                }
            }
            double totalPrice = price * people;
            if (groupType == "Students" && people >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (groupType == "Business" && people >= 100)
            {
                totalPrice = price * (people - 10);
            }
            else if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
