using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicRube
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long hitedCells = 0;
            var matrix = new long[n, n, n];
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Analyze")
                {
                    break;
                }
                var numbers = input.Split(' ').Select(long.Parse).ToList();
                long x = numbers[0];
                long y = numbers[1];
                long z = numbers[2];
                long value = numbers[3];
                if (x >= 0 && x < n &&
                    y >= 0 && y < n &&
                    z >= 0 && z < n)
                {
                    hitedCells++;
                    matrix[x, y, z] += value;
                }
            }
            long sum = 0;
            var unhitedCells = 0;
            for (long xIndex = 0; xIndex < n; xIndex++)
            {
                for (long yIndex = 0; yIndex < n; yIndex++)
                {
                    for (long zIndex = 0; zIndex < n; zIndex++)
                    {
                        if (matrix[xIndex, yIndex, zIndex] == 0)
                        {
                            unhitedCells++;
                        }
                        sum += matrix[xIndex, yIndex, zIndex];
                    }
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine(unhitedCells);
            //Console.WriteLine(n*n*n - hitedCells);
        }
    }
}