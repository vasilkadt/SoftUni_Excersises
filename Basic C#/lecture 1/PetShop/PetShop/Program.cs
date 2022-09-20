using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int packageForDogs = int.Parse(Console.ReadLine());
            int packageForCats = int.Parse(Console.ReadLine());
            double feedForDogs = packageForDogs * 2.5;
            double feedForCats = packageForCats * 4.0;
            Console.WriteLine(feedForDogs+feedForCats+" lv.");
        }
    }
}
