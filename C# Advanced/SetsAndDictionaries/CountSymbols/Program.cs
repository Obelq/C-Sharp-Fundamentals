using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var dictionary = new SortedDictionary<char, int>();
            foreach (var letter in input)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = 0;
                }
                dictionary[letter]++;
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
