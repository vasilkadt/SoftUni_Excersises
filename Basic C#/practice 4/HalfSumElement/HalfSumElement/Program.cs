using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                sum += number;
            }
            double diff = sum - maxNumber;
            if (diff == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Math.Abs(diff)}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - diff)}");
            }
        }
    }
}
