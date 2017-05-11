using System.Text.RegularExpressions;

namespace TelephonyTask
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (Regex.IsMatch(number, @"[^0-9]"))
            {
                return "Invalid number!";
            }
            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (Regex.IsMatch(url,@"[0-9]"))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}!";
        }
    }
}