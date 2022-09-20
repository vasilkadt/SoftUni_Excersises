using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfNaylon = int.Parse(Console.ReadLine());
            int quantityOfPaint = int.Parse(Console.ReadLine());
            int quantityOfThinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sumOfNaylon = (quantityOfNaylon + 2) * 1.5;
            double sumOfPaint = (quantityOfPaint + 0.1 * quantityOfPaint) * 14.5;
            double sumOfThinner = quantityOfThinner * 5.0;
            double allSum = sumOfNaylon + sumOfPaint + sumOfThinner + 0.4;
            double sumForBuilders = allSum * 0.3 * hours;
            Console.WriteLine(allSum+sumForBuilders);
        }
    }
}
