using System;

namespace _05.BirthdayCelebrations
{
    public class Person : IBirthable
    {
        public Person(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public Person(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthday { get; set; }
    }
}
