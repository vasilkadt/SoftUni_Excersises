﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "x3"
            };

            Console.WriteLine($"{car.Make}: {car.Model}");
        }
    }
}
