using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (isTopNum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isTopNum(int num)
        {
            int sum = 0;
            int counter = 0;

            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                {
                    counter++;
                }
                sum += digit;
                num /= 10;
            }

            if (sum % 8 == 0 && counter > 0)
            {
                return true;
            }
            return false;
        }

    }
}
