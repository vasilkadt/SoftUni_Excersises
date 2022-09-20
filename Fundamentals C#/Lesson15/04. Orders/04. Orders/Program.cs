using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            string input;
            while((input=Console.ReadLine())!="buy")
            {
                string[] productArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string productName = productArgs[0];
                double productPrice = double.Parse(productArgs[1]);
                int productQuantity = int.Parse(productArgs[2]);

                if(!products.ContainsKey(productName))
                {
                    products.Add(productName, new double[2]);
                }
                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
