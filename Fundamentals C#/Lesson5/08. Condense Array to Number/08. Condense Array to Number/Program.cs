using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int originalLength = num.Length;

            for (int i = 0; i < originalLength - 1; i++)
            {
                int[] condensed = new int[num.Length - 1];
                for (int j = 0; j < num.Length - 1; j++)
                {
                    condensed[j] = num[j] + num[j + 1];
                }

                num = condensed;
            }
            Console.WriteLine(num[0]);
        }
    }
}
