using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingRegister = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string registration = command[0];
                string username = command[1];

                if (registration == "register")
                {
                    string licensePlateNumber = command[2];
                    if (parkingRegister.ContainsKey(username))
                    {
                        string licenseNumberRegistered = parkingRegister[username];
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumberRegistered}");
                    }
                    else
                    {
                        parkingRegister[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (registration == "unregister")
                {
                    if (!parkingRegister.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        parkingRegister.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkingRegister)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
