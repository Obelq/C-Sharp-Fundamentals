using System;
using System.Collections.Generic;
using System.Linq;

namespace OpinionPoll
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age)
            : this()
        {
            this.age = age;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                Person temp = new Person(name, age);
                if (temp.age > 30)
                {
                    persons.Add(temp);
                }
            }
            List<Person> result = persons.OrderBy(x => x.name).ToList();
            foreach (var person in result)
            {
                Console.WriteLine(person.name + " - " + person.age);
            }
        }
    }
}
