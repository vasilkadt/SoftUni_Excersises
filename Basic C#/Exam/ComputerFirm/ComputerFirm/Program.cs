using System;

namespace ComputerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());
            double potentialSales = 0;
            double sales = 0;
            int reiting = 0;
            double avrRaiting = 0;

            for (int i = 0; i < computers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                reiting = input % 10;
                potentialSales = input / 10;
                if (reiting == 2)
                {
                    sales += 0;
                }
                else if (reiting == 3)
                {
                    sales += 0.5 * potentialSales;
                }
                else if (reiting == 4)
                {
                    sales += 0.7 * potentialSales;
                }
                else if (reiting == 5)
                {
                    sales += 0.85 * potentialSales;
                }
                else if (reiting == 6)
                {
                    sales += potentialSales;
                }

                avrRaiting += reiting;
            }
            Console.WriteLine($"{sales:f2}");
            Console.WriteLine($"{avrRaiting / computers:f2}");
        }
    }
}
