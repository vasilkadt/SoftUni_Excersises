using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> people = new Queue<string>();

            while (true)
            {
                if(input=="Paid")
                {
                    int peopleCount = people.Count;
                    for (int i = 0; i < peopleCount; i++)
                    {
                        Console.WriteLine(people.Dequeue()); 
                    }
                }
                else if(input=="End")
                {
                    Console.WriteLine($"{people.Count} people remaining.");
                    break;
                }
                else
                {
                    people.Enqueue(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
