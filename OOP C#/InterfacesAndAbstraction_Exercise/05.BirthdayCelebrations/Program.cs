using System;
using System.Collections.Generic;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> citizens = new List<IBirthable>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (commandArgs[0] == "Citizen")
                {
                    Person person = new Person(commandArgs[1], int.Parse(commandArgs[2]), commandArgs[3], commandArgs[4]);
                    citizens.Add(person);
                }
                else if(commandArgs[0] == "Robot")
                {
                    Robot robot = new Robot(commandArgs[1], commandArgs[2]);
                }
                else
                {
                    Pet pet = new Pet(commandArgs[1], commandArgs[2]);
                    citizens.Add(pet);
                }
                command = Console.ReadLine();
            }

            string year = Console.ReadLine();
            foreach (var citizen in citizens)
            {
                if (citizen.Birthday.EndsWith(year))
                {
                    Console.WriteLine(citizen.Birthday);
                }
            }
        }
    }
}
