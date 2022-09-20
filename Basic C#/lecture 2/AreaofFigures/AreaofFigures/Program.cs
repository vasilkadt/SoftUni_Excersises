using System;

namespace AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            if(type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a * Math.PI;
            }
            if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
            }
            Console.WriteLine(area);
        }
    }
}
