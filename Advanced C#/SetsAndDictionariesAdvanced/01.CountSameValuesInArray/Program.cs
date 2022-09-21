using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> numberCount = new Dictionary<double, int>();

            foreach (var number in nums)
            {
                if(!numberCount.ContainsKey(number))
                {
                    numberCount.Add(number, 0);
                }

                numberCount[number]++;
            }

            foreach (var item in numberCount)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
