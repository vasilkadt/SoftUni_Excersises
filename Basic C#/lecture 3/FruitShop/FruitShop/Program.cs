using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quontity = double.Parse(Console.ReadLine());
            double price = 0.0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.5; break;
                    case "apple": price = 1.2; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.7; break;
                    case "pineapple": price = 5.5; break;
                    case "grapes": price = 3.85; break;
                    default: Console.WriteLine("error");break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.7; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.9; break;
                    case "grapefruit": price = 1.6; break;
                    case "kiwi": price = 3.0; break;
                    case "pineapple": price = 5.6; break;
                    case "grapes": price = 4.2; break;
                    default: Console.WriteLine("error"); break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
           
            double total = quontity * price;
            if(total!=0)
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
