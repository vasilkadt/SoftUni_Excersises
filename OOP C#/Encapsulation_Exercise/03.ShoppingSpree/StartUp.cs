using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                people = Console.ReadLine().Split(';').ToList()
                   .Select(t => t.Split('='))
                   .Select(p => new Person(p[0], decimal.Parse(p[1])))
                   .ToList();

                products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList()
                 .Select(t => t.Split('='))
                 .Select(p => new Product(p[0], decimal.Parse(p[1])))
                 .ToList();

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] tokens = command.Split();
                    var person = people.First(p => p.Name == tokens[0]);
                    var product = products.First(p => p.Name == tokens[1]);

                    Console.WriteLine(person.AddProductToBag(product));
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            people.ForEach(p => Console.WriteLine(p));
        }
    }
}
