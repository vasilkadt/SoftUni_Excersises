using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if(!contains6To10Characters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(!containsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!containsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(contains6To10Characters(password)&& containsOnlyLettersAndDigits(password)&& containsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool contains6To10Characters(string passwprd)
        {
            if (!(passwprd.Length >= 6 && passwprd.Length <= 10))
            {
                return false;
            }
            return true;
        }
        static bool containsOnlyLettersAndDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool containsAtLeastTwoDigits(string password)
        {
            int counter = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    counter++;
                }
            }
            if (counter < 2)
            {
                return false;
            }
            return true;
        }
    }
}
