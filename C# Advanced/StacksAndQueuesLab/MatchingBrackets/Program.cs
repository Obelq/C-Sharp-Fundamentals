using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var indexesStack = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexesStack.Push(i);
                }
                if (input[i] == ')')
                {
                    var startIndex = indexesStack.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
