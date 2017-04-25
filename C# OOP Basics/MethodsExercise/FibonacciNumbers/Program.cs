using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Fibonacci
    {
        private List<long> fibNums { get; set; } = new List<long>();

        public List<long> GetNumbersInRange(int startPosition, int endPosition)
        {
            fibNums.Add(0);
            fibNums.Add(1);
            for (int i = 2; i < endPosition; i++)
            {
                var currentNum = fibNums[fibNums.Count - 1] + fibNums[fibNums.Count - 2];
                fibNums.Add(currentNum);
            }
            return fibNums.GetRange(startPosition, endPosition - startPosition);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var startPosition = int.Parse(Console.ReadLine());
            var endPosition = int.Parse(Console.ReadLine());

            var fib = new Fibonacci();
            Console.WriteLine(string.Join(", ", fib.GetNumbersInRange(startPosition, endPosition)));
        }
    }
}
