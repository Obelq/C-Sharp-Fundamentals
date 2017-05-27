using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = new Stack<char>();
            foreach (var c in input)
            {
                result.Push(c);
            }
            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }
            Console.WriteLine();
        }
    }
}
