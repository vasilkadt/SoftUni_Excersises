using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladybugsIndexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] field = new int[fieldSize];
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladybugsIndexes.Contains(index))
                {
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                int initalIndex = int.Parse(cmdArgs[0]);
                string directions = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (initalIndex < 0 || initalIndex >= field.Length)
                {
                    continue;
                }
                if (field[initalIndex] == 0)
                {
                    continue;
                }

                field[initalIndex] = 0;
                int nextIndex = initalIndex;
                while (true)
                {
                    if (directions == "right")
                    {
                        nextIndex += flyLength;
                    }
                    else if (directions == "left")
                    {
                        nextIndex -= flyLength;
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
