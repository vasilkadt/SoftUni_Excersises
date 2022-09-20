using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arr = command.Split();
                string operation = arr[0];

                if (operation == "Add")
                {
                    int number = int.Parse(arr[1]);
                    numbers.Add(number);
                }
                else if (operation == "Remove")
                {
                    int number = int.Parse(arr[1]);
                    numbers.Remove(number);
                }
                else if (operation == "RemoveAt")
                {
                    int index = int.Parse(arr[1]);
                    numbers.RemoveAt(index);
                }
                else if (operation == "Insert")
                {
                    int number = int.Parse(arr[1]);
                    int index = int.Parse(arr[2]);
                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
