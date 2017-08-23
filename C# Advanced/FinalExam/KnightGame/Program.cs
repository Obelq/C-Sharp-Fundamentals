using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                var inputRow = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    if (inputRow[j] == 'K')
                    {
                        matrix[i, j] = true;
                    }
                }
            }
            var removedHorses = 0;
            while (true)
            {
                var horses = new Dictionary<KeyValuePair<int, int>, int>();
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col])
                        {
                            var currentHorsePosition = new KeyValuePair<int, int>(row, col);
                            horses[currentHorsePosition] = 0;
                            if (InRange(row + 2, col - 1, n))
                            {
                                if (matrix[row + 2, col - 1])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row + 2, col + 1, n))
                            {
                                if (matrix[row + 2, col + 1])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row - 2, col - 1, n))
                            {
                                if (matrix[row - 2, col - 1])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row - 2, col + 1, n))
                            {
                                if (matrix[row - 2, col + 1])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row - 1, col - 2, n))
                            {
                                if (matrix[row - 1, col - 2])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row + 1, col - 2, n))
                            {
                                if (matrix[row + 1, col - 2])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row - 1, col + 2, n))
                            {
                                if (matrix[row - 1, col + 2])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                            if (InRange(row + 1, col + 2, n))
                            {
                                if (matrix[row + 1, col + 2])
                                {
                                    horses[currentHorsePosition]++;
                                }
                            }
                        }
                    }
                }

                var maxHorse = horses.OrderByDescending(x => x.Value).FirstOrDefault().Key;
                if (horses[maxHorse] == 0)
                {
                    break;
                }
                removedHorses++;
                matrix[maxHorse.Key, maxHorse.Value] = false;
            }

            Console.WriteLine(removedHorses);
        }

        public static bool InRange(int row, int col, int n)
        {
            if (row >= 0 && row < n && col >= 0 && col < n)
            {
                return true;
            }
            return false;
        }

    }
}
