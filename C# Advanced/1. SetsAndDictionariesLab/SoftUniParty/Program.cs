using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = new SortedDictionary<string, bool>();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "PARTY")
                {
                    break;
                }
                guests[command] = false;
            }
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                if (guests.ContainsKey(command))
                {
                    guests[command] = true;
                }
            }
            var result = guests.Where(x => x.Value == false).Select(x => x.Key).ToList();
            Console.WriteLine(result.Count);
            Console.WriteLine(string.Join("\n", result));
        }

        static bool IsVip(string guest)
        {
            return Char.IsDigit(guest[0]);
        }
    }
}
