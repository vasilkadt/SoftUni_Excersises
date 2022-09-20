using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int capasity = 255;
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                sum += liters;
                if (sum > capasity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= liters;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
