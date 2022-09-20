using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>(nums);

            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string[] commandArd = input.Split().ToArray();

                string command = commandArd[0].ToLower();
                if (command == "add")
                {
                    int num1 = int.Parse(commandArd[1]);
                    int num2 = int.Parse(commandArd[2]);
                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command == "remove")
                {
                    int count = int.Parse(commandArd[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                input = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
