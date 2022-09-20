using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues_Exercise
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
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int currElement = 0;
                int min = int.MaxValue;
                bool flag = false;

                while (stack.Count > 0)
                {
                    currElement = stack.Pop();

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
