using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Person
    {
        public string Name { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
        public List<Parent> Parents { get; set; } = new List<Parent>();

        public List<Child> Children { get; set; } = new List<Child>();

        public override string ToString()
        {
            string result = $"{Name}\nCompany:{Company}\nCar:{Car}\nPokemon:";
            foreach (var pokemon in Pokemons)
            {
                result += pokemon;
            }
            result += "\nParents:";
            foreach (var parent in Parents)
            {
                result += parent;
            }
            result += "\nChildren:";
            foreach (var child in Children)
            {
                result += child;
            }
            return result;
        }
    }

    class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public override string ToString()
        {
            return $"\n{Model} {Speed}";
        }
    }

    class Company
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"\n{Name} {Department} {Salary:F2}";
        }
    }

    class Pokemon
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public override string ToString()
        {
            return $"\n{Name} {Type}";
        }
    }

    class Parent
    {
        public string Name { get; set; }

        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"\n{Name} {BirthDay}";
        }
    }
    class Child
    {
        public string Name { get; set; }

        public string BirthDay { get; set; }

        public override string ToString()
        {
            return $"\n{Name} {BirthDay}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var personName = input[0];
                if (personName == "End")
                {
                    break;
                }
                if (!people.ContainsKey(personName))
                {
                    people[personName] = new Person();
                }
                var person = people[personName];
                var command = input[1];
                if (command == "company")
                {
                    person.Company = new Company()
                    {
                        Name = input[2],
                        Department = input[3],
                        Salary = decimal.Parse(input[4])
                    };
                }
                else if (command == "pokemon")
                {
                    person.Pokemons.Add(new Pokemon()
                    {
                        Name = input[2],
                        Type = input[3]
                    });
                }
                else if (command == "parents")
                {
                    person.Parents.Add(new Parent()
                    {
                        Name = input[2],
                        BirthDay = input[3]
                    });
                }
                else if (command == "children")
                {
                    person.Children.Add(new Child()
                    {
                        Name = input[2],
                        BirthDay = input[3]
                    });
                }
                else
                {
                    person.Car = new Car()
                    {
                        Model = input[2],
                        Speed = int.Parse(input[3])
                    };
                }
            }
            var personToShow = Console.ReadLine();
            Console.WriteLine(personToShow + people?[personToShow]);
        }
    }
}
