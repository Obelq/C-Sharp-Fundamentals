using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Type.GetType("NamingExperiment." + "Cat");
            Console.WriteLine(type.Name);
        }
    }

    class Cat
    {
        
    }
}
