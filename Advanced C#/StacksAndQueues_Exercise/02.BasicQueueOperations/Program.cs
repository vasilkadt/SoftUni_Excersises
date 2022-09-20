using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int S = input[1];
            int X = input[2];
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                if (queue.Count > 0)
                {
                    queue.Dequeue();
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int currElement = 0;
                int min = int.MaxValue;
                bool flag = false;

                while (queue.Count > 0)
                {
                    currElement = queue.Dequeue();

                    if (min > currElement)
                    {
                        min = currElement;
                    }

                    if (currElement == X)
                    {
                        Console.WriteLine("true");
                        flag = true;
                        break;
                    }
                }

                if (flag == false)
                {
                    Console.WriteLine(min);
                }
            }
        }
    }
}
