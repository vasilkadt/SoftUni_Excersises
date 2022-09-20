using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournament = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int sumPoints = 0;
            double win = 0;

            for (int i = 0; i < tournament; i++)
            {
                string text = Console.ReadLine();
                if (text == "W")
                {
                    points += 2000;
                    sumPoints += 2000;
                    win++;
                }
                else if (text == "F")
                {
                    points += 1200;
                    sumPoints += 1200;
                }
                else if (text == "SF")
                {
                    points += 720;
                    sumPoints += 720;
                }
            }
            Console.WriteLine($"Final points: " + points);
            Console.WriteLine($"Average points: " + sumPoints / tournament);
            Console.WriteLine($"{(win / tournament * 100):f2}%");
        }
    }
}
