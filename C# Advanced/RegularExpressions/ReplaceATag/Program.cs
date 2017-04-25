using System;
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
            var textList = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                textList.Add(input);
            }
            var textArr = string.Join(" ", textList).Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = string.Join(" ", textArr);
            var pattern = @"<a(\shref=.+)>(.+)<\/a>";
            Console.WriteLine(Regex.Replace(text,pattern, @"[URL href=$1]$2[/URL]"));




        }
    }
}
