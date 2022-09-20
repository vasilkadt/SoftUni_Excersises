using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];
                if (current % 2 == 0)
                {
                    sum += current;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
