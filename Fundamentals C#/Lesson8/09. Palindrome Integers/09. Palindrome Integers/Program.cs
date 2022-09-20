using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input !="END")
            {
                if(isPalindrom(input))
                {
                    Console.WriteLine("true");
                }
                else Console.WriteLine("false");
                input = Console.ReadLine();
            }
        }

        static bool isPalindrom(string number)
        {
            string reversedNum = string.Empty;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNum += number[i];
            }
            if (reversedNum == number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
