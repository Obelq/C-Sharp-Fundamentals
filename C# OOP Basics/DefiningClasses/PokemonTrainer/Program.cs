using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }

    class Pokemon
    {
        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
        public string Name { get; set; }
        public string Element { get; set; }

        public int Health { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "Tournament")
                {
                    break;
                }
                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer;
                if (trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Single(t => t.Name == trainerName).Pokemons.Add(pokemon);
                }
                else
                {
                    trainer = new Trainer(trainerName);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                
                
            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
                    }
                }
            }
            foreach (var t in trainers.OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(t);
            }


        }
    }
}
