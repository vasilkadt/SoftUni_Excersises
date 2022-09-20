using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int minMaterialQuantity = 250;
            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                {"shards", "Shadowmourne" },
                {"fragments", "Valanyr" },
                {"motes", "Dragonwrath" }
            };
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0 }
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string itemObtained = string.Empty;

            while (String.IsNullOrEmpty(itemObtained))
            {
                string materialsLine = Console.ReadLine().ToLower();
                string[] materialsArr = materialsLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < materialsArr.Length; i += 2)
                {
                    int currQuantity = int.Parse(materialsArr[i]);
                    string currMaterial = materialsArr[i + 1];

                    if (keyMaterials.ContainsKey(currMaterial))
                    {
                        keyMaterials[currMaterial] += currQuantity;

                        if (keyMaterials[currMaterial] >= minMaterialQuantity)
                        {
                            itemObtained = craftingTable[currMaterial];
                            keyMaterials[currMaterial] -= minMaterialQuantity;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currMaterial))
                        {
                            junk[currMaterial] = 0;
                        }
                        junk[currMaterial] += currQuantity;
                    }
                }
            }
            printOutput(keyMaterials, junk, itemObtained);
        }
        static void printOutput(Dictionary<string, int> keyMaterialsLEft, Dictionary<string, int> junk, string itemObtained)
        {
            Console.WriteLine($"{itemObtained} obtained!");

            foreach (var kvp in keyMaterialsLEft)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
