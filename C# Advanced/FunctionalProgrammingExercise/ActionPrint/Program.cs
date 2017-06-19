using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine(n);
            Console.ReadLine()
                .Split(' ')
                .ToList()
                .ForEach(printer);
        }
    }
}
