using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = rows * columns;

            switch(ticket)
            {
                case "Premiere": income = income * 12.0; ;break;
                case "Normal": income *= 7.5; break;
                case "Discount": income *= 5.0; break;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
