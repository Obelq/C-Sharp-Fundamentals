using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
