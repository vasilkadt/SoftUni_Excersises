using System;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();

            for (int i = 0; i < text.Count - 1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    text.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
