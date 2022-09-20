using System;

namespace _03.PrimaryDiagonal
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

            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        sum += matrix[i, j];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
