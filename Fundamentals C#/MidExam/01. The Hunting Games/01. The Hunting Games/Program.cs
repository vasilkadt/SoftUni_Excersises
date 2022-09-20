using System;
using System.Numerics;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int peopleCount = int.Parse(Console.ReadLine());
        double groupEnergy = double.Parse(Console.ReadLine());
        double waterPerDayForOneDude = double.Parse(Console.ReadLine());
        double foodPerDayForOneDude = double.Parse(Console.ReadLine());

        double totalWaterNeeded = waterPerDayForOneDude * peopleCount * days;
        double totalFoodNeeded = foodPerDayForOneDude * peopleCount * days;

        double lostEnergyToday = 0;
        for (int i = 1; i <= days; i++)
        {
            lostEnergyToday = double.Parse(Console.ReadLine());
            groupEnergy = groupEnergy - lostEnergyToday;
            if (groupEnergy <= 0)
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFoodNeeded:f2} food and {totalWaterNeeded:f2} water.");
                return;
            }
            if (i % 2 == 0)
            {
                groupEnergy = groupEnergy + (groupEnergy * 0.05);
                totalWaterNeeded = totalWaterNeeded - (totalWaterNeeded * 0.30);
            }
            if (i % 3 == 0)
            {
                totalFoodNeeded = totalFoodNeeded - (totalFoodNeeded / peopleCount);
                groupEnergy = groupEnergy + (groupEnergy * 0.10);
            }

        }
        if (groupEnergy > 0)
        {
            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:f2} energy!");
        }

    }
}