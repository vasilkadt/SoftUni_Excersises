using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Queue<string> commandsQueue = new Queue<string>(commands);

            for (int row = 0; row < size; row++)
            {
                char[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            int currentRow = 0;
            int currentCol = 0;
            int maxCoal = 0;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        maxCoal++;
                    }
                }
            }

            int coalSum = 0;
            while (true)
            {
                string currentCommand = commandsQueue.Dequeue();
                if (currentCommand == "up")
                {
                    if (Exist(matrix, currentRow - 1, currentCol))
                    {
                        currentRow -= 1;
                    }
                }
                else if (currentCommand == "down")
                {
                    if (Exist(matrix, currentRow + 1, currentCol))
                    {
                        currentRow += 1;
                    }
                }
                else if (currentCommand == "right")
                {
                    if (Exist(matrix, currentRow, currentCol + 1))
                    {
                        currentCol += 1;
                    }
                }
                else if (currentCommand == "left")
                {
                    if (Exist(matrix, currentRow, currentCol - 1))
                    {
                        currentCol -= 1;
                    }
                }

                if (matrix[currentRow, currentCol] == 'c')
                {
                    coalSum++;
                    matrix[currentRow, currentCol] = '*';
                    if (coalSum == maxCoal)
                    {
                        Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                        break;
                    }
                }
                else if (matrix[currentRow, currentCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                    break;
                }

                if (commandsQueue.Count == 0)
                {
                    Console.WriteLine($"{maxCoal - coalSum} coals left. ({currentRow}, {currentCol})");
                    break;
                }
            }
        }
        private static bool Exist(char[,] matrix, int startRow, int startCol)
        {
            return startRow >= 0 && startRow < matrix.GetLength(0) &&
             startCol >= 0 && startCol < matrix.GetLength(1);
        }
    }
}
