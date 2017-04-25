using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(.)\1+";
            var regex = new Regex(pattern);
            var matches = regex.Replace(input, "$1");
            Console.WriteLine(matches);
        }
    }
}
