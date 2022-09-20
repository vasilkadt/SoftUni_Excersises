using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();
            int longerCount = Math.Max(num1.Count, num2.Count);
            for (int i = 0; i < longerCount; i++)
            {
                if (i < num1.Count)
                {
                    result.Add(num1[i]);
                }
                if (i < num2.Count)
                {
                    result.Add(num2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}