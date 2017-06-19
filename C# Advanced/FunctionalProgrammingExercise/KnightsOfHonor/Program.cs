using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {

            var words = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Action<ICollection<string>> sirAdder = names =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine("Sir " + name);
                }
            };
            sirAdder(words);
        }
    }
}
