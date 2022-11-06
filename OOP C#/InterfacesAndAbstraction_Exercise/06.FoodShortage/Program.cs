using System;
using System.Collections.Generic;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBuyer> citizens = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command.Length == 4)
                {
                    Citizen citizen = new Citizen(command[0], int.Parse(command[1]), command[2], command[3]);
                    citizens.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(command[0], int.Parse(command[1]), command[2]);
                    citizens.Add(rebel);
                }
            }

            string command2 = Console.ReadLine();
            while (command2 != "End")
            {
                foreach (var citizen in citizens)
                {
                    if (citizen.Name == command2)
                    {
                        citizen.BuyFood();
                    }
                }
                command2 = Console.ReadLine();
            }

            int sum = 0;
            foreach (var citizen in citizens)
            {
                sum += citizen.Food;
            }

            Console.WriteLine(sum);
        }
    }
}
