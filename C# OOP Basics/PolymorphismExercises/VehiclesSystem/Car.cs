using System;

namespace VehiclesSystem
{
    public class Car:Vehicle
    {
       

        public Car(double litersFuel, double fuelUsage, double tankCapacity) : base(litersFuel, fuelUsage, tankCapacity)
        {
        }

        public override void Refuel(double addedFuel)
        {
            var newFuelQuantity = this.LitersFuel + addedFuel;
            if (newFuelQuantity > this.TankCapacity)
            {
                Console.WriteLine("Cannot fit fuel in tank");
            }
            else
            {
                base.Refuel(addedFuel);
            }
            
        }

        public override void Drive(double distance)
        {
            var newFuelLevel = this.LitersFuel - ((0.9 + this.FuelUsage) * distance);
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