using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine().Split('-').ToArray();
            while (input[0] != "search")
            {
                phonebook[input[0]] = input[1];
                input = Console.ReadLine().Split('-').ToArray();
            }
            var searchName = Console.ReadLine();
            while (searchName != "stop" && searchName != "Stop")
            {
                if (phonebook.ContainsKey(searchName))
                {
                    Console.WriteLine($"{searchName} -> {phonebook[searchName]}");
                }
                else
                {
                    Console.WriteLine($"Contact {searchName} does not exist.");
                }
                searchName = Console.ReadLine();
            }
        }
    }
}
