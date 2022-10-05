﻿using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startWithCapital = w => char.IsUpper(w[0]);

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => startWithCapital(x))
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
