using System;
using System.Collections.Generic;

namespace _03._Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shop = new Dictionary<string, int>();
            string command;
            int counter = 0;

            while ((command = Console.ReadLine()) != "Complete")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArg[0];
                int quantity = int.Parse(cmdArg[1]);
                string foodName = cmdArg[2];

                if (quantity <= 0)
                {
                    continue;
                }

                if (type == "Receive")
                {
                    if (shop.ContainsKey(foodName))
                    {
                        shop[foodName] += quantity;
                    }
                    else
                    {
                        shop.Add(foodName, quantity);
                    }
                }
                else if (type == "Sell")
                {
                    if (!shop.ContainsKey(foodName))
                    {
                        Console.WriteLine($"You do not have any {foodName}.");
                    }
                    else
                    {
                        if (shop[foodName] < quantity)
                        {
                            Console.WriteLine($"There aren't enough {foodName}. You sold the last {shop[foodName]} of them.");
                            counter += shop[foodName];
                            shop.Remove(foodName);
                        }
                        else
                        {
                            int currQuantity = shop[foodName] - quantity;
                            shop[foodName] -= quantity;
                            counter += quantity;
                            Console.WriteLine($"You sold {quantity} {foodName}.");
                            if (currQuantity <= 0)
                            {
                                shop.Remove(foodName);
                            }
                        }
                    }
                }
            }

            foreach (var item in shop)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine($"All sold: {counter} goods");
        }
    }
}
