using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        string input = Console.ReadLine();
        string pattern = @"\[[^\[]+<([0-9]+)REGEH([0-9]+)>[^]]+\]";
        var matches = Regex.Matches(input, pattern);
        int currentIndex = 0;
        foreach (Match match in matches)
        {
            if (!Regex.IsMatch(match.Groups[0].Value, @"\s"))
            {
                // Possible mistake
                int firstNum;
                var firstCheck = int.TryParse(match.Groups[1].Value, out firstNum);
                int secondNum;
                var secondCheck = int.TryParse(match.Groups[2].Value, out secondNum);
                if (firstCheck && secondCheck)
                {
                    currentIndex += firstNum;
                    sb.Append(input[currentIndex % input.Length + currentIndex / input.Length]);
                    currentIndex += secondNum;
                    sb.Append(input[currentIndex % input.Length + currentIndex / input.Length]);
                }

            }
        }
        Console.WriteLine(sb.ToString());
    }
}