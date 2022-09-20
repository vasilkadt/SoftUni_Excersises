using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double priceForAll = meters * 7.61;
            double discount = 0.18 * priceForAll;
            double finalPrice = priceForAll - discount;
            Console.WriteLine($"The final price is: {finalPrice}");
            Console.WriteLine($"The discount is: {discount}");
        }
    }
}
