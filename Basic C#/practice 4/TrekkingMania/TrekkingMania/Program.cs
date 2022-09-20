using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            int sumPeople = 0;

            for (int i = 0; i < countGroups; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());
                sumPeople += countPeople;
                if (countPeople <= 5)
                {
                    p1 += countPeople;
                }
                else if (countPeople <= 12)
                {
                    p2 += countPeople;
                }
                else if (countPeople <= 25)
                {
                    p3 += countPeople;
                }
                else if (countPeople <= 40)
                {
                    p4 += countPeople;
                }
                else
                {
                    p5 += countPeople;
                }
            }
            p1 = p1 / sumPeople * 100;
            p2 = p2 / sumPeople * 100;
            p3 = p3 / sumPeople * 100;
            p4 = p4 / sumPeople * 100;
            p5 = p5 / sumPeople * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
