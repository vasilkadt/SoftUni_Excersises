using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string operation = commands[0];

                if (operation == "Add")
                {
                    int value = int.Parse(commands[1]);
                    numbers.Add(value);
                }
                else if (operation == "Remove")
                {
                    int value = int.Parse(commands[1]);
                    numbers.Remove(value);
                }
                else if (operation == "Replace")
                {
                    int value = int.Parse(commands[1]);
                    int replacement = int.Parse(commands[2]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == value)
                        {
                            numbers[i] = replacement;
                            break;
                        }
                    }
                }
                else if (operation == "Collapse")
                {
                    int value = int.Parse(commands[1]);
                    numbers.RemoveAll(x => x < value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}