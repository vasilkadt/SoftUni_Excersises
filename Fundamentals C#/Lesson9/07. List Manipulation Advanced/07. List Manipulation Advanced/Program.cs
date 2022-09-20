using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command;
            bool hasChanges = false;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arr = command.Split();
                string operation = arr[0];

                if (operation == "Add")
                {
                    int number = int.Parse(arr[1]);
                    numbers.Add(number);
                    hasChanges = true;
                }
                else if (operation == "Remove")
                {
                    int number = int.Parse(arr[1]);
                    numbers.Remove(number);
                    hasChanges = true;
                }
                else if (operation == "RemoveAt")
                {
                    int index = int.Parse(arr[1]);
                    numbers.RemoveAt(index);
                    hasChanges = true;
                }
                else if (operation == "Insert")
                {
                    int number = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    numbers.Insert(index, number);
                    hasChanges = true;
                }
                else if (operation == "Contains")
                {
                    int number = int.Parse(arr[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else Console.WriteLine("No such number");
                }
                else if (operation == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (operation == "PrintOdd")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (operation == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (operation == "Filter")
                {
                    string condition = arr[1];
                    int number = int.Parse(arr[2]);
                    List<int> result = GetFilteredNumbers(numbers, condition, number);
                    Console.WriteLine(string.Join(" ", result));
                }
            }

            if (hasChanges)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static List<int> GetFilteredNumbers(List<int> allNumbers, string condition, int numberToCompare)
        {
            if (condition == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberToCompare);
                return result;
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToCompare);
                return result;
            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else return allNumbers;
        }
    }
}
