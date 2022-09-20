using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while(word.Contains(wordToRemove))
            {
                int stratIndexOfWordToRemove = word.IndexOf(wordToRemove);
                word = word.Remove(stratIndexOfWordToRemove, wordToRemove.Length);
            }
            Console.WriteLine(word);
        }
    }
}
