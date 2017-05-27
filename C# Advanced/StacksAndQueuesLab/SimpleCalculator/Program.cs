using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var stack = new Stack<string>();
            int result = 0;
            foreach (var element in input)
            {
                stack.Push(element);
            }
            while (stack.Count > 1)
            {
                var currentNum = int.Parse(stack.Pop());
                var sign = stack.Pop();
                if (sign == "+")
                {
                    result += currentNum;
                }
                else if (sign == "-")
                {
                    result -= currentNum;
                }
            }
            result += int.Parse(stack.Pop());
            Console.WriteLine(result);
        }
    }
}
