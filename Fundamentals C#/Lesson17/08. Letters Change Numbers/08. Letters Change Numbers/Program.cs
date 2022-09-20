using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordSum(word);
            }
            Console.WriteLine($"{sum:f2}");
        }

        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPosition = getAlphabeticalPossitionOfCharacter(firstLetter);
            int lastLetterPosition = getAlphabeticalPossitionOfCharacter(lastLetter);
        
            if(Char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPosition;
            }
            else if(Char.IsLower(firstLetter))
            {
                sum = (decimal)num + firstLetterPosition;
            }

            if (Char.IsUpper(lastLetter))
            {
                sum -= lastLetterPosition;
            }
            else if (Char.IsLower(lastLetter))
            {
                sum += lastLetterPosition;
            }

            return sum;
        }

        static int getAlphabeticalPossitionOfCharacter( char ch)
        {
            if(!Char.IsLetter(ch))
            {
                return -1;
            }

            char chCI = Char.ToLowerInvariant(ch);

            return (int)chCI - 96;
        }
    }
}
