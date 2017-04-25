using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"[a-zA-Z][\w.-]*[a-zA-Z]@([A-Za-z][A-Za-z-]*[A-Za-z]\.)+[A-Za-z]+");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
