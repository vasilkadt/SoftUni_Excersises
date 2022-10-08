using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "BMW",
                Model = "x3",
                Year=2002,
                FuelConsumption=0.4,
                FuelQuantity=100
            };

            Console.WriteLine(car.WhoAmI());
        }
    }
}
