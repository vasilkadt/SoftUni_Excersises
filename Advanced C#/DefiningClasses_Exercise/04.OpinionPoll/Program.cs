using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(command[0], int.Parse(command[1]));
                people.Add(person);
            }

            var orderedList = people.OrderBy(x => x.Name).Where(x => x.Age > 30);
            foreach (var person in orderedList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
