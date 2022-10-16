using System;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                box.Items.Add(Console.ReadLine());
            }

            string elementToCompare = Console.ReadLine();
            Console.WriteLine(box.Count(elementToCompare));
        }
    }
}


