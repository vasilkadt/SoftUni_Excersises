using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] rowData = Console.ReadLine().Split(", ");
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(rowData[j]);
                }
            }

            int max = int.MinValue;
            int indexMaxRow = 0;
            int indexMaxCol = 0;
            int sum = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    sum += matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > max)
                    {
                        max = sum;
                        indexMaxRow = i;
                        indexMaxCol = j;
                    }
                    sum = 0;
                }
            }

            Console.Write(matrix[indexMaxRow, indexMaxCol] + " ");
            Console.WriteLine(matrix[indexMaxRow, indexMaxCol + 1]);
            Console.Write(matrix[indexMaxRow + 1, indexMaxCol] + " ");
            Console.WriteLine(matrix[indexMaxRow + 1, indexMaxCol + 1]);
            Console.WriteLine(max);
        }
    }
}
