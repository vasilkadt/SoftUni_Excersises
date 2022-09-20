using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;

            string input = Console.ReadLine();
            while (input != "No More Books")
            {
                if (input == name)
                {
                    break;
                }
                counter++;
                input = Console.ReadLine();
            }
            if (input == name)
            {
            Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
