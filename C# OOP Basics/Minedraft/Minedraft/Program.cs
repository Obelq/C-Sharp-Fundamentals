using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var draftManager = new DraftManager();
        while (true)
        {
            var arguments = Console.ReadLine().Split(' ').ToList();
            string command = arguments[0];
            arguments = arguments.Skip(1).ToList();
            switch (command)
            {
                case "RegisterHarvester":
                    var registerHarvester = draftManager.RegisterHarvester(arguments);
                    Console.WriteLine(registerHarvester);
                    break;
                case "RegisterProvider":
                    var registerProvider = draftManager.RegisterProvider(arguments);
                    Console.WriteLine(registerProvider);
                    break;
                case "Day":
                    var day = draftManager.Day();
                    Console.WriteLine(day);
                    break;
                case "Mode":
                    var mode = draftManager.Mode(arguments);
                    Console.WriteLine(mode);
                    break;
                case "Check":
                    var check = draftManager.Check(arguments);
                    Console.WriteLine(check);
                    break;
                case "Shutdown":
                    var shutdown = draftManager.ShutDown();
                    Console.WriteLine(shutdown);
                    return;
            }
        }
    }
}

