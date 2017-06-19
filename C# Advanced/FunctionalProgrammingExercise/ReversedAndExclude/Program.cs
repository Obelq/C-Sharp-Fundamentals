using System;
using System.Collections.Generic;
using System.Linq;

namespace ReversedAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var divider = int.Parse(Console.ReadLine());
            Predicate<int> divFinder = x => x % divider != 0;
            Func<List<int>, List<int>> divideFilter = nums =>
            {
                var result = nums.FindAll(divFinder);
                result.Reverse();
                return result;
            };
            Console.WriteLine(string.Join(" ", divideFilter(numbers)));
        }
    }
}
