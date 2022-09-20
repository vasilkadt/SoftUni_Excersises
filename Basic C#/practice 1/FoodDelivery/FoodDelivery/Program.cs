using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());
            double priceForChikenMenu = chickenMenu * 10.35;
            double priceForFishMenu = fishMenu * 12.40;
            double priceForVegetarianMenu = vegetarianMenu * 8.15;
            double allPrice = priceForChikenMenu + priceForFishMenu + priceForVegetarianMenu;
            double desertPrice = 0.2 * allPrice;
            Console.WriteLine(allPrice + desertPrice + 2.5);
        }
    }
}
