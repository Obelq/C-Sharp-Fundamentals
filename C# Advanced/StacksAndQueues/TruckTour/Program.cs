using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckTour
{
    class GasPump
    {
        public long amountOfGas;
        public long distanceToNext;
        public int index;
        public GasPump(long distanceToNext, long amountOfGas, int index)
        {
            this.amountOfGas = amountOfGas;
            this.distanceToNext = distanceToNext;
            this.index = index;
        }

        public override string ToString()
        {
            string info = string.Format($"GAS: {this.amountOfGas}; DISTANCE{this.distanceToNext}");
            return info;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var pumps = new Queue<GasPump>();           
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
                var pump = new GasPump(input[1], input[0], i);
                pumps.Enqueue(pump);
            }

            GasPump startPump = new GasPump(0, 0 , -1);
            long fuel = 0;
            bool checker = true;
            while (true)
            {
                var currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                if (currentPump == startPump)
                {
                    Console.WriteLine(startPump.index);
                    break;
                }
                
                if (checker)
                {
                    startPump = currentPump;
                    checker = false;
                }
                fuel += currentPump.amountOfGas;
                fuel -= currentPump.distanceToNext;
                if (fuel < 0)
                {
                    fuel = 0;
                    checker = true;
                    continue;
                }
                
            }
           

        }
    }
}
