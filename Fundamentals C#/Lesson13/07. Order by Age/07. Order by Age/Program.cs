using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ").ToArray();
            List<Person> people = new List<Person>();

            while (command[0]!="End")
            {
                string name = command[0];
                string ID = command[1];
                int age = int.Parse(command[2]);

                Person person = new Person(name, ID, age);
                people.Add(person);

                command = Console.ReadLine().Split(" ").ToArray();
            }

            List<Person> sortedPersons = people.OrderBy(p => p.Age).ToList();
            foreach (Person person in sortedPersons)
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public Person(string name, string ID, int age)
        {
            this.Name = name;
            this.ID = ID;
            this.Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
}
