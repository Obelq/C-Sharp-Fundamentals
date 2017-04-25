using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesEmails = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
                var twoSimbols = email.Substring(email.Length-2, 2).ToLower();
                if (twoSimbols == "us" || twoSimbols == "uk")
                {
                    continue;
                }
                namesEmails[name] = email;
            }
            foreach (var item in namesEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
