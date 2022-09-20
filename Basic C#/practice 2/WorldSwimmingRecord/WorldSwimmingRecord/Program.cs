using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsFerMeter = double.Parse(Console.ReadLine());
            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;
            double IvanRecord = distance * secondsFerMeter + delay;
            if(IvanRecord < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {IvanRecord:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(IvanRecord - worldRecord):f2} seconds slower.");
            }
        }
    }
}
