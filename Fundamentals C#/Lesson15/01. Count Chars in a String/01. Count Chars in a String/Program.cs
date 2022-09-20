using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            string text = Console.ReadLine();

            foreach (var item in text)
            {
                if (!occurances.ContainsKey(item))
                {
                    occurances.Add(item, 1);
                }
                else
                {
                    occurances[item]++;
                }
            }

            foreach (var item in occurances.Where(ch => ch.Key != ' '))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
