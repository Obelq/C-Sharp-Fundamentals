using System;

namespace VehiclesSystem
{
    public class Truck : Vehicle
    {
        public Truck(double litersFuel, double fuelUsage, double tankCapacity) : base(litersFuel, fuelUsage, tankCapacity)
        {
        }

        public override void Refuel(double addedFuel)
        {
            addedFuel = addedFuel * 0.95;
            base.Refuel(addedFuel);
        }

        public override void Drive(double distance)
        {
            var newFuelLevel = this.LitersFuel - ((1.6 + this.FuelUsage) * distance);
            if (newFuelLevel < 0)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                this.LitersFuel = newFuelLevel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
        }
    }
}