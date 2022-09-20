using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Result(num1, @operator, num2));
        }

        static int Result(int num1, char @operator, int num2)
        {
            int result = 0;
            if (@operator == '+')
            {
                result = num1 + num2;
            }
            else if (@operator == '-')
            {
                result = num1 - num2;
            }
            else if (@operator == '*')
            {
                result = num1 * num2;
            }
            else if (@operator == '/')
            {
                result = num1 / num2;
            }
            return result;
        }
    }
}
