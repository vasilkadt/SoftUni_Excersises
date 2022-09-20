using System;

namespace SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    combinationsCounter++;
                    if (a + b == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationsCounter} ({a} + {b} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNum}");
        }
    }
}
