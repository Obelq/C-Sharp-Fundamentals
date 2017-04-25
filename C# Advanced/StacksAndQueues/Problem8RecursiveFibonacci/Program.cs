using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8RecursiveFibonacci
{
    class Program
    {
        public static long[] numbers;
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());
            numbers = new long[n + 1];
            long result = getFibonacci(n);
            Console.WriteLine(result);
        }

        private static long getFibonacci(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            if (numbers[n] != 0)
            {
                return numbers[n];
            }
            numbers[n] = getFibonacci(n - 1) + getFibonacci(n - 2);
            return numbers[n];
        }
    }
}
