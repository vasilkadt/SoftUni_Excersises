using System;
using System.Collections.Generic;

namespace _07.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            HashSet<string> cars = new HashSet<string>();

            while (input[0] != "END")
            {
                if (input[0] == "IN")
                {
                    cars.Add(input[1]);
                }
                else
                {
                    cars.Remove(input[1]);
                }
                input = Console.ReadLine().Split(", ");
            }

            if (cars.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
