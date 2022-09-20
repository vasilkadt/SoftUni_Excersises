﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expresion = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(expresion.Reverse());

            int result = int.Parse(stack.Pop());
            while (stack.Count > 0)
            {
                if (stack.Pop() == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else
                {
                    result -= int.Parse(stack.Pop());
                }
            }
            Console.WriteLine(result);
        }
    }
}
