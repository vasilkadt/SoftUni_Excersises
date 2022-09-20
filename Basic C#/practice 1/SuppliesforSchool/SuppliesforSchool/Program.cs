using System;

namespace SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int pencils = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litersOfPreparat = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());
            double priceOfPencils = pencils * 5.8;
            double priceOfMarkers = markers * 7.2;
            double priceOfPreparat = litersOfPreparat * 1.2;
            double allPrice = priceOfMarkers + priceOfPencils + priceOfPreparat;
            double finalSum = allPrice - (allPrice * (discount / 100));
            Console.WriteLine(finalSum);
        }
    }
}