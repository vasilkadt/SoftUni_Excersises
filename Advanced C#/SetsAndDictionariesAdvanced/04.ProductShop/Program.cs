using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _04.ProductShop
{
    class Program
    {
        public static object Dicrionary { get; private set; }

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Dictionary<string, Dictionary<string, double>> shop = new Dictionary<string, Dictionary<string, double>>();

            string[] command = Console.ReadLine().Split(", ");
            while (command[0] != "Revision")
            {
                string name = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);

                if (!shop.ContainsKey(name))
                {
                    shop.Add(name, new Dictionary<string, double>());
                }
                shop[name].Add(product, price);
                command = Console.ReadLine().Split(", ");
            }

            shop = shop.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in shop)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
