using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operation == "add")
            {
                add(num1, num2);
            }
            else if(operation == "multiply")
            {
                multiply(num1, num2);
            }
            else if (operation == "substract")
            {
                substract(num1, num2);
            }
            else if (operation == "divide")
            {
                divide(num1, num2);
            }
        }

        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
