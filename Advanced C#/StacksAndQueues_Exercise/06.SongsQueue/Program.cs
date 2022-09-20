using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            Queue<string> queue = new Queue<string>(songs);

            while (queue.Count > 0)
            {
                string[] command = Console.ReadLine().Split();
                string commandType = command[0];

                if (commandType == "Play")
                {
                    queue.Dequeue();
                }
                else if (commandType == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                else if (commandType == "Add")
                {
                    string songToAdd = String.Join(" ", command.Skip(1));
                    if (queue.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                        continue;
                    }
                    else
                    {
                        queue.Enqueue(songToAdd);
                    }
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
