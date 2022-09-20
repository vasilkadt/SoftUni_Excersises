using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int counter = 0;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++) // 2 1 1 2 3 3 2 2 2 1
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter > maxLength)
                    {
                        maxLength = counter;
                        index = i - counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = index + 1; i <= index + maxLength + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
