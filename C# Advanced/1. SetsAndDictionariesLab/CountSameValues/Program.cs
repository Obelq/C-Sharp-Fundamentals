using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSameValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var occurrences = new SortedDictionary<double, int>();

            foreach (var number in input)
            {
                if (!occurrences.ContainsKey(number))
                {
                    occurrences[number] = 0;
                }
                occurrences[number]++;
            }
            foreach (var occurrence in occurrences)
            {
                Console.WriteLine($"{occurrence.Key} - {occurrence.Value} times");
            }
        }
    }
}
