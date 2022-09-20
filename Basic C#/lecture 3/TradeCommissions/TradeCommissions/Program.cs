using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{0.05 * sales:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{0.045 * sales:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{0.055 * sales:F2}");
                }
                else Console.WriteLine("error");

            }
            else if (sales > 500 && sales <= 1000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{0.07 * sales:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{0.075 * sales:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{0.08 * sales:F2}");
                }
                else Console.WriteLine("error");

            }
            else if (sales > 1000 && sales <= 10000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{0.08 * sales:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{0.1 * sales:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{0.12 * sales:F2}");
                }
                else Console.WriteLine("error");

            }
            else if (sales > 10000)
            {
                if (town == "Sofia")
                {
                    Console.WriteLine($"{0.12 * sales:F2}");
                }
                else if (town == "Varna")
                {
                    Console.WriteLine($"{0.13 * sales:F2}");
                }
                else if (town == "Plovdiv")
                {
                    Console.WriteLine($"{0.145 * sales:F2}");
                }
                else Console.WriteLine("error");

            }




            else
                Console.WriteLine("error");

        }
    }
}
