using System;
using System.Linq;
using System.Text;

namespace _01._Easter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Easter")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArg[0];

                if (type == "Replace")
                {
                    char currentChar = char.Parse(cmdArg[1]);
                    char newChar = char.Parse(cmdArg[2]);
                    input = input.Replace(currentChar, newChar);
                    Console.WriteLine(input);
                }
                else if (type == "Remove")
                {
                    string substring = cmdArg[1];
                    if (!input.Contains(substring))
                    {
                        Console.WriteLine(input);
                        continue;
                    }
                    int index = input.IndexOf(substring);
                    //if (index < 0 || index > input.Length - 1)
                    //{
                    //    Console.WriteLine(input);
                    //    continue;
                    //}
                    input = input.Remove(index, substring.Length);
                    Console.WriteLine(input);
                }
                else if (type == "Includes")
                {
                    string word = cmdArg[1];
                    if (input.Contains(word))
                    {
                        Console.WriteLine("True");
                    }
                    else Console.WriteLine("False");
                }
                else if (type == "Change")
                {
                    string LowerOrUpper = cmdArg[1];
                    if (LowerOrUpper == "Lower")
                    {
                        input = input.ToLower();
                    }
                    else if (LowerOrUpper == "Upper")
                    {
                        input = input.ToUpper();
                    }
                    Console.WriteLine(input);
                }
                else if (type == "Reverse")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);

                    if (startIndex < 0 || startIndex > endIndex || endIndex > input.Length - 1)
                    {
                        continue;
                    }

                    string substring = string.Empty;
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        substring += input[i];
                    }
                    string reverseSubstring = string.Join("", substring.Reverse());
                    Console.WriteLine(reverseSubstring);
                }
            }
        }
    }
}
