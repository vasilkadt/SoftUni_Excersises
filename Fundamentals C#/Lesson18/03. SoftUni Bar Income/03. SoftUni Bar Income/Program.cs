using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalIncom = 0m;
            string pattern = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^\%\$\|\.]*?\<(?<product>\w+)\>[^\%\$\|\.]*?\|(?<count>\d+)\|[^\%\$\|\.]*?(?<price>\d+(\.\d+)?)\$";

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match orderInfo = Regex.Match(input, pattern);
                if(orderInfo.Success)
                {
                    string name = orderInfo.Groups["name"].Value;
                    string product = orderInfo.Groups["product"].Value;
                    int count = int.Parse(orderInfo.Groups["count"].Value);
                    decimal price = decimal.Parse(orderInfo.Groups["price"].Value);

                    decimal totalPrice = count * price;
                    totalIncom += totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncom:f2}");
        }
    }
}
