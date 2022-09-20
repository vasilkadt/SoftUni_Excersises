using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);
            List<int> result = new List<int>();

            int countQueue = queue.Count;

            for (int i = 0; i < countQueue; i++)
            {
                int currentNum = queue.Dequeue();
                if (currentNum % 2 == 0)
                {
                    result.Add(currentNum);
                }
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
