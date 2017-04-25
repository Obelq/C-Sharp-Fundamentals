using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //ActionPoint();

            //KnightsOfHonor();

            //CustomMinFunction();

            //FindEvensOrOdds();

            //AppliedArithmetics();

            //ReverseAndExclude();

            //PredicateForNames();

            CustomComparator();
        }

        private static void CustomComparator()
        {
            
        }

        private static void PredicateForNames()
        {
            var maxNameLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Predicate<string> namePredicate = n => n.Length <= maxNameLength;
            Func<List<string>, List<string>> nameFilter = n => n.FindAll(namePredicate);
            Console.WriteLine(string.Join("\n", nameFilter(names)));
        }

        private static void ReverseAndExclude()
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

        private static void AppliedArithmetics()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int, int> add = x => x + 1;
            Func<int, int> subtract = x => x - 1;
            Func<int, int> multiply = x => x * 2;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ", x));
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "print")
                {
                    print(numbers);
                }
                else if (command == "add")
                {
                    numbers = numbers.Select(add).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtract).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiply).ToArray();
                }
            }
        }

        private static void FindEvensOrOdds()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var keyWord = Console.ReadLine();
            var startNumber = input[0];
            var endNumber = input[1];
            var numbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> oddFinder = x => x % 2 != 0;
            Predicate<int> evenFinder = x => x % 2 != 1;
            List<int> result = new List<int>();
            if (keyWord == "odd")
            {
                result = numbers.FindAll(oddFinder);
            }
            else
            {
                result = numbers.FindAll(evenFinder);
            }
            Console.WriteLine(string.Join(" ", result));

        }

        private static void CustomMinFunction()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Func<List<int>, int> minFinder = nums => nums.Min();
            Console.WriteLine(minFinder(numbers));
        }

        private static void KnightsOfHonor()
        {
            var words = Console.ReadLine()
                .Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries)
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

        private static void ActionPoint()
        {
            Action<ICollection<string>> myAction = strings =>
            {
                foreach (var s in strings)
                {
                    Console.WriteLine(s);
                }
            };
            var words = Console.ReadLine().Split(' ').ToArray();
            myAction(words);

        }
    }
}
