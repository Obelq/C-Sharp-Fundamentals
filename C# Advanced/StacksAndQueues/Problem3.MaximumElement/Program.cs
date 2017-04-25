using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem3.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var command = input[0];
                
                if (command == 1)
                {
                    numbers.Push(input[1]);
                }
                else if (command == 2)
                {
                    numbers.Pop();
                }
                else
                {
                    Console.WriteLine(numbers.Max());
                }
            }
        }
    }
}
