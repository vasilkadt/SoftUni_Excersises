using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(countVowel(str));
        }

        static int countVowel(string word)
        {
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'o' || word[i] == 'e' || word[i] == 'i' || word[i] == 'u' 
                    || word[i] == 'A' || word[i] == 'O' || word[i] == 'E' || word[i] == 'I' || word[i] == 'U')
                { counter++; }
            }
            return counter;
        }
    }
}
