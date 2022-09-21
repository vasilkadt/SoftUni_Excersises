using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if(!occurrences.ContainsKey(input[i]))
                {
                    occurrences.Add(input[i], 0);
                }
                occurrences[input[i]]++;
            }
            occurrences=occurrences.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
