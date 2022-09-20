using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            int point = int.Parse(Console.ReadLine());
            string price = Console.ReadLine();

            int leftSum = 0;
            int rightSum = 0;

            int index = numbers[point];
            for (int i = 0; i < point; i++)
            {
                if (price == "cheap" && numbers[i] <= index)
                {
                    leftSum += numbers[i];
                }
                else if(price == "expensive" && numbers[i] >= index)
                {
                    leftSum += numbers[i];
                }
            }
            for (int j = point + 1; j < numbers.Count; j++)
            {
                if (price == "cheap" && numbers[j] <= index)
                {
                    rightSum += numbers[j];
                }
                else if (price == "expensive" && numbers[j] >= index)
                {
                    rightSum += numbers[j];
                }
            }

            if (price == "cheap")
            {
                int minPrice = int.MaxValue;
                string position = string.Empty;
                if (leftSum < rightSum)
                {
                    minPrice = leftSum;
                    position = "Left";
                }
                else if (rightSum < leftSum)
                {
                    minPrice = rightSum;
                    position = "Right";
                }
                else
                {
                    minPrice = leftSum;
                    position = "Left";
                }
                Console.WriteLine($"{position} - {minPrice}");
            }
            else if (price == "expensive")
            {
                int maxPrice = int.MinValue;
                string position = string.Empty;
                if (leftSum > rightSum)
                {
                    maxPrice = leftSum;
                    position = "Right";
                }
                else if (rightSum > leftSum)
                {
                    maxPrice = rightSum;
                    position = "Left";
                }
                else
                {
                    maxPrice = leftSum;
                    position = "Left";
                }
                Console.WriteLine($"{position} - {maxPrice}");
            }
        }
    }
}