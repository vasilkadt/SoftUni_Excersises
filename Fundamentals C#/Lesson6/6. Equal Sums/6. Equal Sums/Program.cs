using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;

            for (int i = 0; i < arr.Length; i++) // 1 2 3 3
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
                rightSum = 0;
                leftSum += arr[i];
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
