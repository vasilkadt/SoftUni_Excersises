using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();
                string operation = commands[0];
                int element = int.Parse(commands[1]);

                if (operation == "Delete")
                {
                    num.RemoveAll(x => x == element);
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    num.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
