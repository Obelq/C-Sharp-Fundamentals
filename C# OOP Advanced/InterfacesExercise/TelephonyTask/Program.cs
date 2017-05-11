using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephonyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartphone = new Smartphone();
            Console.ReadLine().Split(' ')
                .ToList()
                .ForEach(x => Console.WriteLine(smartphone.Call(x)));
            Console.ReadLine().Split(' ')
                .ToList()
                .ForEach(x => Console.WriteLine(smartphone.Browse(x)));
        }
    }
}
