using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicsMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Over!")
                {
                    break;
                }

                var encryptedMessage = new StringBuilder();
                var textLength = long.Parse(Console.ReadLine());
                string pattern = @"^([0-9]*)([a-zA-Z]{" + textLength + @"})([0-9]*)[^a-zA-Z]*$";
                var match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string word = match.Groups[2].Value;
                    string numbers = match.Groups[1].Value + match.Groups[3].Value;
                    foreach (var numberStr in numbers)
                    {
                        var number = long.Parse("" + numberStr);
                        if (number < 0 ||number >= word.Length)
                        {
                            encryptedMessage.Append(" ");
                        }
                        else
                        {
                            encryptedMessage.Append(word[number]);
                        }
                    }
                    Console.WriteLine($"{word} == {encryptedMessage}");
                }
                

            }
            
        }
    }
}
