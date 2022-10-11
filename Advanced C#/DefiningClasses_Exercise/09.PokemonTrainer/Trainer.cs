using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            PokemonCollection = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> PokemonCollection { get; set; }

        public void CheckPokemon(string element)
        {
            if (this.PokemonCollection.Any(p => p.Element == element))
            {
                NumberOfBadges++;
            }
            else
            {
                for (int i = 0; i < this.PokemonCollection.Count; i++)
                {
                    Pokemon currentPokemon = this.PokemonCollection[i];

                    currentPokemon.Health -= 10;

                    if (currentPokemon.Health <= 0)
                    {
                        this.PokemonCollection.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
