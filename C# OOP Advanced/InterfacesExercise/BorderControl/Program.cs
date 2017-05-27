using System;
using System.Collections.Generic;
using System.Linq;
using BorderControl.Models;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IIdentifiable> identifiables = new List<IIdentifiable>();

            //while (true)
            //{
            //    var command = Console.ReadLine().Split(' ').ToList();
            //    if (command[0] == "End")
            //    {
            //        break;
            //    }

            //    if (command.Count == 3)
            //    {
            //        var citizen = new Citizen(command[0], int.Parse(command[1]), command[2]);
            //        identifiables.Add(citizen);
            //    }
            //    else
            //    {
            //        var robot = new Robot(command[0], command[1]);
            //        identifiables.Add(robot);
            //    }
            //}
            //var secretCheck = Console.ReadLine();

            //var detained = identifiables.Where(i => i.Id.EndsWith(secretCheck)).Select(i => i.Id).ToList();
            //Console.WriteLine(string.Join(Environment.NewLine, detained));

            var birthdates = new List<IBirthdate>();

            while (true)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                if (command[0] == "End")
                {
                    break;
                }

                if (command.Count == 5)
                {
                    var citizen = new Citizen(command[1], int.Parse(command[2]), command[3], command[4]);
                    birthdates.Add(citizen);
                }
                else if(command[0] == "Pet")
                {
                    var pet = new Pet(command[1], command[2]);
                    birthdates.Add(pet);
                }
            }

            var searchYear = Console.ReadLine();
            var result = birthdates.Select(b => b.Birthdate).Where(x => x.Split('/')[2] == searchYear);
            foreach (var birthdate in result)
            {
                Console.WriteLine(birthdate);
            }
        }
    }
}
