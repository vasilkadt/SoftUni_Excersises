using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> people = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commands = command.Split(' ');
                if (commands.Length > 1)
                {
                    string type = commands[0];
                    if (type == "Add")
                    {
                        int wagon = int.Parse(commands[1]);
                        people.Add(wagon);
                    }
                }
                else
                {
                    int morePeople = int.Parse(commands[0]);
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (people[i] + morePeople <= capacity)
                        {
                            people[i] += morePeople;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", people));
        }
    }
}
