using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalSum = 0m;
            List<string> furnitures = new List<string>();

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);

                if (furnitureInfo.Success)
                {
                    string furnitureName = furnitureInfo.Groups["name"].Value;
                    decimal furniturePrice = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int furnitureQuantity = int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitures.Add(furnitureName);
                    totalSum += furniturePrice * furnitureQuantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string furitureName in furnitures)
            {
                Console.WriteLine(furitureName);
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
