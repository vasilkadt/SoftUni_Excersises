using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            stack.Push(string.Empty);

            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string commandType = cmdArg[0];

                if (commandType == "1")
                {
                    string commandValue = cmdArg[1];
                    text.Append(commandValue);
                    stack.Push(text.ToString());
                }
                else if (commandType == "2")
                {
                    int count = int.Parse(cmdArg[1]);
                    text = text.Remove(text.Length - count, count);
                    stack.Push(text.ToString());
                }
                else if (commandType == "3")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (index >= 0 && index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (commandType == "4")
                {
                    stack.Pop();
                    string previousVersion = stack.Peek();
                    text = new StringBuilder(previousVersion);
                }
            }
        }
    }
}
