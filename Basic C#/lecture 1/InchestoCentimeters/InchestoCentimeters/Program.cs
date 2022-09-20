using System;

namespace InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double santimetres = inches * 2.54;
            Console.WriteLine(santimetres);
        }
    }
}
