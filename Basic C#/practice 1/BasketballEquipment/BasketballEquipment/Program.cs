using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double trainers = tax - tax * 0.4;
            double clothes = trainers - trainers * 0.2;
            double ball = clothes / 4;
            double accesories = ball / 5;
            Console.WriteLine(tax + trainers + clothes + ball + accesories);
        }
    }
}
