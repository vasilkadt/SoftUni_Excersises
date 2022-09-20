using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplier = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());
            if (startNum <= 10)
            {
                for (int i = startNum; i <= 10; i++)
                {
                    Console.WriteLine($"{multiplier} X {i} = {multiplier * i}");
                }
            }
            else
            {
                Console.WriteLine($"{multiplier} X {startNum} = {multiplier*startNum}");
            }
        }
    }
}
