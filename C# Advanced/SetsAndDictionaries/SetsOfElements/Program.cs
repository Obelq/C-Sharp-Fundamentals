using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);
            var names1 = new HashSet<string>();
            var names2 = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                names1.Add(input);
            }
            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine();
                names2.Add(input);
            }
            names1.IntersectWith(names2);
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
        }
    }
}
