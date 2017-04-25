using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<long>();
            numbers.Push(1);
            numbers.Push(1);
            for (int i = 2; i <= n; i++)
            {
                var firstPart = numbers.Pop();
                var secondPart = numbers.Peek();
                long currentNum = firstPart + secondPart;
                numbers.Push(firstPart);
                numbers.Push(currentNum);
            }
            Console.WriteLine(numbers.Peek());


        }
    }
}
