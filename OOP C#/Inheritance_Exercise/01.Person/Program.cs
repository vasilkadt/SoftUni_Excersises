using System;

namespace _01.Person
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            if(age>15)
            {
                Person person = new Person(name, age);
                Console.WriteLine(person);
            }
            else
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
        }
    }
}
