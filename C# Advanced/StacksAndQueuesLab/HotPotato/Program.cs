using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var queue = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (var kid in kids)
            {
                queue.Enqueue(kid);
            }
            while (queue.Count > 1)
            {
                counter++;
                var currentElement = queue.Dequeue();
                if (counter % n == 0)
                {
                    Console.WriteLine("Removed " + currentElement);
                }
                else
                {
                    queue.Enqueue(currentElement);
                }
            }
            Console.WriteLine("Last is " + queue.Dequeue());
        }
    }
}
