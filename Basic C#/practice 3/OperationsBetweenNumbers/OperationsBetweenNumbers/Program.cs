using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0.0;
            if (operation == '+')
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
                }
            }
            else if (operation == '/')
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = 1.0 * num1 / num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {result:f2}");
                }
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} {operation} {num2} = {result}");
                }
            }
        }
    }
}
