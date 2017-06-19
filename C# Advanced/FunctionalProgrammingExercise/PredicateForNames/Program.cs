using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxNameLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Predicate<string> namePredicate = n => n.Length <= maxNameLength;
            Func<List<string>, List<string>> nameFilter = n => n.FindAll(namePredicate);
            Console.WriteLine(string.Join("\n", nameFilter(names)));
        }
    }
}
