using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resoursces = new Dictionary<string, long>();

            string command;
            while ((command = Console.ReadLine()) != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if (!resoursces.ContainsKey(command))
                {
                    resoursces.Add(command, quantity);
                }
                else
                {
                    resoursces[command] += quantity;
                }
            }

            foreach (var item in resoursces)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
