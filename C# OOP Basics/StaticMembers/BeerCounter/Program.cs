using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCounter
{
    class BeerCounter
    {
        public static int beerInStock;
        public static int beersDrankCount;

        public static void BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
        }

        public static void DrinkBeer(int bottlesCount)
        {
            beerInStock -= bottlesCount;
            beersDrankCount += bottlesCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (input[0] == "End")
                {
                    break;
                }
                var boughtBeers = int.Parse(input[0]);
                var soldBeers = int.Parse(input[1]);
                
                BeerCounter.BuyBeer(boughtBeers);
                BeerCounter.DrinkBeer(soldBeers);
            }
            Console.WriteLine($"{BeerCounter.beerInStock} {BeerCounter.beersDrankCount}");
        }
    }
}
