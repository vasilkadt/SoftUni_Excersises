using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long factorial1 = factorial(num1);
            long factorial2 = factorial(num2);
            double division =(double) factorial1 / factorial2;
            Console.WriteLine($"{division:f2}");
        }

        static long factorial(int num)
        {
            long result = 1;
            for (int i = num; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
