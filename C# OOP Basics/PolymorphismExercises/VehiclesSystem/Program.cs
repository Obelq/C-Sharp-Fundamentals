using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesSystem
{

    class Program
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split(' ').ToList();
            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));

            var truckInput = Console.ReadLine().Split(' ').ToList();
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));

            var busInput = Console.ReadLine().Split(' ').ToList();
            Vehicle bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]));

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(' ').ToList();
                var amount = double.Parse(command[2]);
                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        car.Drive(amount);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Drive(amount);
                    }
                    else
                    {
                        bus.Drive(amount);
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(amount);
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(amount);
                    }
                    else
                    {
                        bus.Refuel(amount);
                    }
                }
                else
                {
                    bus.DriveEmpty(amount);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
    }
}
