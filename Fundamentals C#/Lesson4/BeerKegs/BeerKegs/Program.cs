using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double max = 0;
            string maxModel = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;
                if (volume > max)
                {
                    max = volume;
                    maxModel = model;
                }
                volume = 0;
            }
            Console.WriteLine(maxModel);
        }
    }
}
