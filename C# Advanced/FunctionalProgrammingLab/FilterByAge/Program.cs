using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var people = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var name = input[0];
                var personAge = int.Parse(input[1]);
                people.Add(new KeyValuePair<string, int>(name, personAge));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();
            //Implementation of these methos on next slides 
            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer =
                CreatePrinter(format);

            PrintFilteredStudent(people, tester, printer);


        }

        private static void PrintFilteredStudent
            (List<KeyValuePair<string, int>> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people.Where(x => tester(x.Value)))
            {
                printer(person);
            }
        }

        public static Func<int, bool> CreateTester
            (string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }
        public static Action<KeyValuePair<string, int>>
            CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person =>
                        Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }


    }
}
