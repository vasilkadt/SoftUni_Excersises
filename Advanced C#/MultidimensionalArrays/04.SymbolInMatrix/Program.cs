using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string symbols = Console.ReadLine();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = symbols[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(matrix[i,j]==symbol)
                    {
                        found = true;
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            if(found==false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
