using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(clothes);

            int sum = 0;
            int rackNeeded = 1;
            int queueLen = queue.Count;
            for (int i = 0; i < queueLen; i++)
            {
                sum += queue.Peek();
                if (sum <= capacity)
                {
                    if (queue.Count > 0)
                        queue.Dequeue();
                }
                else
                {
                    rackNeeded++;
                    sum = 0;
                    i--;
                }
            }

            Console.WriteLine(rackNeeded);
        }
    }
}
