using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long factorialSum = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {
                char currentCharacter = number[i];
                int currentDigit = (int)currentCharacter - 48;

                long currentDigitFactorial = 1;
                for (int j = currentDigit; j > 1; j--)
                {
                    currentDigitFactorial *= j;
                }

                factorialSum += currentDigitFactorial;
            }

            if(factorialSum==int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
