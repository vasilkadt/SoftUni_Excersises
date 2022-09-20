using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int reach = int.Parse(Console.ReadLine());
            string service = (Console.ReadLine());
            int sum = 0;
            while (service != "closed")
            {
                if (service == "haircut")
                {
                    service = Console.ReadLine();
                    if (service == "mens") sum += 15;
                    else if (service == "ladies") sum += 20;
                    else if (service == "kids") sum += 10;
                }
                else if (service == "color")
                {
                    service = Console.ReadLine();
                    if (service == "touch up") sum += 20;
                    else if (service == "full color") sum += 30;
                }
                if (sum < reach)
                    service = Console.ReadLine();
                else break;
            }
            if (sum >= reach)
                Console.WriteLine($"You have reached your target for the day!");
            else
                Console.WriteLine($"Target not reached! You need {reach - sum}lv. more.");
            Console.WriteLine($"Earned money: {sum}lv.");
        }
    }
}