using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var elements = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var boxOfElements = Console.ReadLine().Split(' ').ToArray();
                foreach (var item in boxOfElements)
                {
                    elements.Add(item);
                }
                
            }
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
