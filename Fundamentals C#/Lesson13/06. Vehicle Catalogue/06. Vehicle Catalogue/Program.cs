﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string type = arg[0];
                string model = arg[1];
                string color = arg[2];
                int horsePower = int.Parse(arg[3]);

                Vehicle currVihacle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(currVihacle);
            }

            string input;
            while((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == input));
            }

            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (Vehicle car in onlyCars)
            {
                totalCarsHorsepower += car.HorsePower;
            }

            foreach (Vehicle truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HorsePower}";

            return vehicleStr;
        }
    }
}
