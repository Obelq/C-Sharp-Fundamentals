using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubicAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var regions = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Count em all")
                {
                    break;
                }
                var splitedInput = input
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string regName = splitedInput[0];
                string meteorType = splitedInput[1];
                long value = long.Parse(splitedInput[2]);
                if (!regions.ContainsKey(regName))
                {
                    regions[regName] = new Dictionary<string, long>()
                        {{"Green", 0}, {"Red", 0}, {"Black", 0}};
                }
                AddMeteorPolongs(regions[regName], meteorType, value);
            }
            
            foreach (var region in regions.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine(region.Key);
                foreach (var meteor in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {meteor.Key} : {meteor.Value}");
                }
            }

        }
        public static void AddMeteorPolongs(Dictionary<string, long> colors, string type, long value)
        {
            if (type == "Green")
            {
                colors["Green"] += value;
            }
            if (type == "Red")
            {
                colors["Red"] += value;
            }
            if (type == "Black")
            {
                colors["Black"] += value;
            }

            var greenAddition = colors["Green"] / 1000000;
            colors["Green"] %= 1000000;
            colors["Red"] += greenAddition;
            var redAddition = colors["Red"] / 1000000;
            colors["Red"] %= 1000000;
            colors["Black"] += redAddition;

        }
    }
}
