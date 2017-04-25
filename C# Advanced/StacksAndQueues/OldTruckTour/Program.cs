using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var fuelPoint = new long[n];
            var distances = new long[n];
            var successfulIndex = 0;
            long fuel = 0;

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                fuelPoint[i] = input[0];
                distances[i] = input[1];
            }
            for (int i = 0; i < n; i++)
            {
                fuel += fuelPoint[i];
                fuel -= distances[i];
                if (fuel - distances[i] < 0)
                {
                    if (i + 1 >= n)
                    {
                        Console.WriteLine("Impossible");
                        break;
                    }
                    successfulIndex = i + 1;
                    fuel = 0;
                    continue;
                }
            }
            if (successfulIndex == 0)
            {
                Console.WriteLine(successfulIndex);
                return;
            }
            for (int i = 0; i < n; i++)
            {
                fuel += fuelPoint[i];
                fuel -= distances[i];
                if (fuel - distances[i] < 0)
                {
                    Console.WriteLine("Impossible");
                    return;
                }
            }
            Console.WriteLine(successfulIndex);

        }
    }
}
