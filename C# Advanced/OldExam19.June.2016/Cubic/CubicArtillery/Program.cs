using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicArtillery
{
    class Program
    {
        static void Main(string[] args)
        {
            var bunkers = new Queue<string>();
            var maxCapacity = long.Parse(Console.ReadLine());
            var currentBunkerWeapons = new Queue<long>();
            long currentCapacity = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Bunker Revision")
                {
                    break;
                }
                var elements = input.Split(' ');
                foreach (var element in elements)
                {
                    long weapon;
                    var IsNum = long.TryParse(element, out weapon);
                    if (IsNum)
                    {
                        while (true)
                        {
                            if (currentCapacity + weapon > maxCapacity)
                            {
                                if (bunkers.Count == 1)
                                {
                                    if (weapon <= maxCapacity)
                                    {
                                        currentBunkerWeapons.Enqueue(weapon);
                                        currentCapacity += weapon;
                                        while (currentCapacity > maxCapacity)
                                        {
                                            currentCapacity -= currentBunkerWeapons.Dequeue();
                                        }
                                    }

                                }
                                else
                                {
                                    Console.Write($"{bunkers.Dequeue()} -> ");
                                    Console.WriteLine(currentBunkerWeapons.Count == 0
                                        ? "Empty"
                                        : string.Join(", ", currentBunkerWeapons));
                                    currentBunkerWeapons.Clear();
                                    currentCapacity = 0;
                                    continue;
                                }
                            }
                            else
                            {
                                currentBunkerWeapons.Enqueue(weapon);
                                currentCapacity += weapon;
                            }
                            break;
                        }
                    }
                    else
                    {
                        bunkers.Enqueue(element);
                    }
                }
            }
        }
    }
}
