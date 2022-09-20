using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string operation = commands[0];

                if (operation == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                }
                else if (operation == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    if (!(index >= 0 && index < numbers.Count))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (operation == "Shift")
                {
                    string leftOrRight = commands[1];
                    int count = int.Parse(commands[2]);

                    if (leftOrRight == "left")
                    {
                        ShiftLeft(numbers, count);
                    }
                    else if (leftOrRight == "right")
                    {
                        ShiftRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftLeft(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int i = 0; i < realPerformedCount; i++)
            {
               // int firstElement = numbers[0];
                int firstElement = numbers.First();
                numbers.Remove(firstElement);
                numbers.Add(firstElement);
            }
        }
        static void ShiftRight(List<int> numbers, int count)
        {
            int realPerformedCount = count % numbers.Count;

            for (int i = 0; i < realPerformedCount; i++)
            {
                int lastElement = numbers.Last();
                //numbers.Remove(lastElement); INCORRECT!!!
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastElement);
            }
        }
    }
}
