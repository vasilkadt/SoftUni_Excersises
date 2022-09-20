using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newNum = num;

            int counter = 0;
            while (num > 0)
            {
                num /= 10;
                counter++;
            }
            int sum = 0;

            for (int i = 0; i < counter; i++)
            {
                int digit = newNum % 10;
                newNum /= 10;
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
