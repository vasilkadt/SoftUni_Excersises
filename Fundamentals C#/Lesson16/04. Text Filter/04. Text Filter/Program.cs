﻿using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in input)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}
