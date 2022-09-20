using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> myQ = new Queue<int>(orders);

            int sum = 0;

            Console.WriteLine(myQ.Max());

            while (myQ.Count > 0)
            {
                int currentEl = myQ.Peek();

                sum += currentEl;

                if (sum <= foodQuantity)
                {
                    myQ.Dequeue();
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", myQ));
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}