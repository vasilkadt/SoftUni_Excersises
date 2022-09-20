using System;

namespace Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 15;
            if (newMinutes > 59)
            {
                minutes =newMinutes - 60;
                hours = hours + 1;
                if (hours == 24)
                {
                    hours = 0;
                }
            }
            else
            {
                minutes += 15;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
