using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Tournament")
                {
                    break;
                }

                string[] info = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Trainer trainer = trainers.SingleOrDefault(t => t.Name == info[0]);

                if (trainer == null)
                {
                    trainer = new Trainer(info[0]);
                    trainer.PokemonCollection.Add(new Pokemon(info[1], info[2], int.Parse(info[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.PokemonCollection.Add(new Pokemon(info[1], info[2], int.Parse(info[3])));
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    trainer.CheckPokemon(command);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
            }
        }
    }
}