using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddSum = 0;
            int evenSum = 0;

            foreach (int item in input)
            {
                if (item % 2 == 0)
                {
                    evenSum += item;
                }
                else oddSum += item;
            }
            Console.WriteLine(evenSum-oddSum);
        }
    }
}
