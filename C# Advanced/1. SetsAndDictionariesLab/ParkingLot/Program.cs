using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new HashSet<string>();
            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    parking.Remove(inputParams[1]);
                }

                input = Console.ReadLine();
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join("\n", parking.OrderBy(x => x)));
            }
        }
    }
}
