using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClinic
{
    class Animal
    {
        public string Name { get; set; }

        public string Breed { get; set; }
    }

    class AnimalClinic
    {
        public static int healedAnimalsCount;
        public static int rehabilitatedAnimalsCount;
        public static List<Animal> RehabilitatedAnimals = new List<Animal>();
        public static List<Animal> HealedAnimals = new List<Animal>();

        public static string HealAnimal(Animal animal)
        {
            healedAnimalsCount++;
            HealedAnimals.Add(animal);
            return $"Patient {healedAnimalsCount}: [{animal.Name} ({animal.Breed})] has been healed!";
        }
        public static string RehabilitateAnimal(Animal animal)
        {
            rehabilitatedAnimalsCount++;
            RehabilitatedAnimals.Add(animal);
            return  $"Patient {rehabilitatedAnimalsCount}: [{animal.Name} ({animal.Breed})] has been rehabilitated!";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "End")
                {
                    break;
                }
                Animal animal = new Animal()
                {
                    Name = input[0],
                    Breed = input[1]
                };
                if (input[2] == "heal")
                {
                    Console.WriteLine(AnimalClinic.HealAnimal(animal));
                    
                }
                else
                {
                    Console.WriteLine(AnimalClinic.RehabilitateAnimal(animal));
                }
            }
            var lastCommand = Console.ReadLine();

            Console.WriteLine($"Total healed animals: {AnimalClinic.healedAnimalsCount}");
            Console.WriteLine($"Total rehabilitated animals: {AnimalClinic.rehabilitatedAnimalsCount}");

            if (lastCommand == "heal")
            {
                foreach (var healedAnimal in AnimalClinic.HealedAnimals)
                {
                    Console.WriteLine($"{healedAnimal.Name} {healedAnimal.Breed}");
                }
            }
            else
            {
                foreach (var rehabilitatedAnimal in AnimalClinic.RehabilitatedAnimals)
                {
                    Console.WriteLine($"{rehabilitatedAnimal.Name} {rehabilitatedAnimal.Breed}");
                }
            }
        }
    }
}
