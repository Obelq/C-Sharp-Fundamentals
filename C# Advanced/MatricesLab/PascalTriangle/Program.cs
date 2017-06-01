using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            long[][] pascalMatrix = new long[rows][];

            int rowLength = 1;
            for (int row = 0; row < rows; row++)
            {
                pascalMatrix[row] = new long[rowLength];

                pascalMatrix[row][0] = 1;
                pascalMatrix[row][rowLength - 1] = 1;

                for (int col = 1; col < rowLength - 1; col++)
                {
                    pascalMatrix[row][col] = pascalMatrix[row - 1][col - 1] + pascalMatrix[row - 1][col];
                }

                rowLength++;
            }

            foreach (var row in pascalMatrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
