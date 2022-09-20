using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] topIntegers = new int[arr.Length];
            int topIntegerIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] >= arr[i])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                 
                if(isTopInteger)
                {
                    topIntegers[topIntegerIndex] = arr[i];
                    topIntegerIndex++;
                }
            }
            for (int i = 0; i < topIntegerIndex; i++)
            {
                Console.Write($"{topIntegers[i]} ");
            }
        }
    }
}
