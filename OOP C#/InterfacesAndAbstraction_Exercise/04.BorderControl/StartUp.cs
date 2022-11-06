using System;
using System.Collections.Generic;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<ICitizen> citizens = new List<ICitizen>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if(commandArgs.Length==3)
                {
                    Person person = new Person(commandArgs[0], int.Parse(commandArgs[1]), commandArgs[2]);
                    citizens.Add(person);
                }
                else
                {
                    Robot robot = new Robot(commandArgs[0], commandArgs[1]);
                    citizens.Add(robot);
                }
                command = Console.ReadLine();
            }

            string invalidId = Console.ReadLine();
            foreach (var citizen in citizens)
            {
                if (citizen.Id.EndsWith(invalidId))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
