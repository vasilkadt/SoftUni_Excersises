using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(middleElement(word));
        }
        static string middleElement(string word)
        {
            string result = string.Empty;
            if (word.Length % 2 != 0)
            {
                result += word[word.Length / 2];
            }
            else
            {
                result += word[word.Length / 2 - 1];
                result += word[word.Length / 2];
            }
            return result;
        }
    }
}
