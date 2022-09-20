using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if(grade >= 5.5 && grade <= 6.0)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
