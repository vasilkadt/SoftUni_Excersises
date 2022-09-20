using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int possiblePasses = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            int countPassCars = 0;
            while (true)
            {
                if (input == "green")
                {
                    for (int i = 0; i < possiblePasses; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            countPassCars++;
                        }
                    }
                }
                else if (input == "end")
                {
                    Console.WriteLine($"{countPassCars} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
