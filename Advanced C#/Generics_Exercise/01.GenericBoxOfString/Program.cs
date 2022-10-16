using System;

namespace _01.GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                box.Items.Add(Console.ReadLine());
            }

            Console.WriteLine(box.ToString());
        }
    }
}
