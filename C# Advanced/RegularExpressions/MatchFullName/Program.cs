﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
                var regex = new Regex(pattern);
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    Console.WriteLine(match);
                }
            }
            
        }
    }
}
