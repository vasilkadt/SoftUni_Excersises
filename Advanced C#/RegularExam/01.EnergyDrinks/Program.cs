using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.EnergyDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> caffeinе = new Stack<int>(Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            Queue<int> energyDrinks = new Queue<int>(Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());

            int maximumCaffeine = 0;

            while (caffeinе.Count != 0 && energyDrinks.Count != 0)
            {
                int element1 = caffeinе.Pop();
                int element2 = energyDrinks.Dequeue();

                int calculate = element1 * element2;
                if (calculate + maximumCaffeine <= 300)
                {
                    maximumCaffeine += calculate;
                }
                else
                {
                    energyDrinks.Enqueue(element2);
                    if (maximumCaffeine - 30 >= 0)
                    {
                        maximumCaffeine -= 30;
                    }
                }
            }

            if (energyDrinks.Count > 0)
            {
                Console.WriteLine($"Drinks left: {String.Join(", ", energyDrinks)}");
                Console.WriteLine($"Stamat is going to sleep with { maximumCaffeine } mg caffeine.");
            }
            else if (energyDrinks.Count == 0)
            {
                Console.WriteLine($"At least Stamat wasn't exceeding the maximum caffeine.");
                Console.WriteLine($"Stamat is going to sleep with { maximumCaffeine } mg caffeine.");
            }
        }
    }
}
