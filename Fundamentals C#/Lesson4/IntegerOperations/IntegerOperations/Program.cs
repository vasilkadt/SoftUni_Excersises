﻿using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            long sum = (long)first + second;
            long division = sum / third;
            long multiplication = division * fourth;

            Console.WriteLine(multiplication);
        }
    }
}
