using System;

namespace SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine()); //5
            var sum = 0;

            for (int i = 0; i < num; i++)
            {
                int currentOddNumber = 1 + (i * 2);
                sum += currentOddNumber;
                Console.WriteLine(currentOddNumber);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
