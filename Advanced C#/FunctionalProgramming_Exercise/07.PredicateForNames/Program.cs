using System;
using System.Collections.Generic;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<string>, int, List<string>> countLength = (names, count) =>
            {
                List<string> result = new List<string>();

                foreach (var name in names)
                {
                    if (name.Length <= count)
                    {
                        result.Add(name);
                    }
                }

                return result;
            };

            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<string> namess = new List<string>(names);

            Console.WriteLine(String.Join(Environment.NewLine, countLength(namess, length)));
        }
    }
}
