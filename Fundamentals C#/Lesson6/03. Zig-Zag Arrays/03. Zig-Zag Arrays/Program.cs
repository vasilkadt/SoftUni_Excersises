using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstNum = currentRowData[0];
                int secondNum = currentRowData[1];

                if (row % 2 != 0)
                {
                    arr1[row - 1] = firstNum;
                    arr2[row - 1] = secondNum;
                }
                else
                {
                    arr2[row - 1] = firstNum;
                    arr1[row - 1] = secondNum;
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
