using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._The_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|\$|\%|\*|\&)(?<name>[A-Za-z]+)(\1)=(?<number>\d+)\!\!(?<code>[\!-\~]+)";

            while (true)
            {
                string input = Console.ReadLine();

                Match matches = Regex.Match(input, pattern);
                if (!matches.Success)
                {
                    Console.WriteLine("Nothing found!");
                    continue;
                }
                else
                {
                    string name = matches.Groups["name"].Value;
                    int number = int.Parse(matches.Groups["number"].Value);
                    string code = matches.Groups["code"].Value;
                    if (number != code.Length)
                    {
                        Console.WriteLine("Nothing found!");
                        continue;
                    }
                    else if(number == code.Length)
                    {
                        StringBuilder text = new StringBuilder();
                        foreach (char symbol in code)
                        {
                            int symbolInInt = (int)symbol;
                            symbolInInt += number;
                            text.Append((char)symbolInInt);
                        }
                        Console.Write("Coordinates found! ");
                        Console.WriteLine($"{name} -> {text}");
                        break;
                    }
                }
            }
        }
    }
}
