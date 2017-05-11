using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> identifiables = new List<IIdentifiable>();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "End")
                {
                    break;
                }

                if (command.Count == 3)
                {
                    var citizen = new Citizen(command[0], int.Parse(command[1]), command[2]);
                    identifiables.Add(citizen);
                }
                else
                {
                    var robot = new Robot(command[0], command[1]);
                    identifiables.Add(robot);
                }
            }
            var secretCheck = Console.ReadLine();

            var detained = identifiables.Where(i => i.Id.EndsWith(secretCheck)).Select(i => i.Id).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, detained));
        }
    }
}
