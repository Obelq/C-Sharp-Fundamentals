using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByGroup
{
    class Person
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Person()
                {
                    Name = input[0] + " " + input[1],
                    Group = int.Parse(input[2])
                };
                people.Add(student);
            }
            var groupedPeople = people.GroupBy(p => p.Group).OrderBy(g => g.Key);
            foreach (var g in groupedPeople)
            {
                Console.WriteLine($"{g.Key} - {string.Join(", ", g.Select(p => p.Name))}");
            }
        }
    }
}
