using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            while (true)
            {
                var type = Console.ReadLine();
                if (type == "stop")
                {
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());
                if (!resources.ContainsKey(type))
                {
                    resources[type] = 0;
                }
                resources[type] += quantity;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
