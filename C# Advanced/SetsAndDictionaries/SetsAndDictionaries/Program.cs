using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                names.Add(input);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
