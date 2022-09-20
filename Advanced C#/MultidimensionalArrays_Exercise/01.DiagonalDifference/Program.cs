using System;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string[] rowData = Console.ReadLine().Split();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(rowData[j]);
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;
            for (int i = 0; i < size; i++)
            {
                primaryDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[i, size - 1 - i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }
    }
}
