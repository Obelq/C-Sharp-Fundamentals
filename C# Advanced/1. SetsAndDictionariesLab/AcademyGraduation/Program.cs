using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademyGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var students = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var scores = Console.ReadLine()
                    .Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
                students[name] = scores;
            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }

        }
    }
}
