using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var endNum = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Func<int, int, bool> filter = (a, b) => a % b != 0;
            var result = new List<int>();
            for (int i = 1; i <= endNum; i++)
            {
                bool checker = true;
                foreach (var divider in dividers)
                {
                    if (filter(i, divider))
                    {
                        checker = false;
                        break;
                    }
                }
                if (checker)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
