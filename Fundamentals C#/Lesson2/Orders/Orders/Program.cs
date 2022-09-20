﻿using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            for (int i = 0; i < orders; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                double price = ((days * capsulesCount) * capsulePrice);
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
