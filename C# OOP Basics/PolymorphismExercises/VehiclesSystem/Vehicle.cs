using System;
using System.IO;

namespace VehiclesSystem
{
    public abstract class Vehicle
    {
        private double litersFuel;
        private double fuelUsage;
        private double tankCapacity;

        protected Vehicle(double litersFuel, double fuelUsage, double tankCapacity)
        {
            this.LitersFuel = litersFuel;
            this.FuelUsage = fuelUsage;
            this.TankCapacity = tankCapacity;
        }

        public Vehicle(double litersFuel, double fuelUsage)
        {
            this.litersFuel = litersFuel;
            this.fuelUsage = fuelUsage;
        }

        public double FuelUsage
        {
            get { return this.fuelUsage; }
            protected set { this.fuelUsage = value; }
        }

        public double LitersFuel
        {
            get { return this.litersFuel; }
            protected set
            {
                if (value < 0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    this.litersFuel = value;

                }
            }
        }

        public double TankCapacity
        {
            get { return this.tankCapacity; }
            protected set { this.tankCapacity = value; }
        }

        public virtual void Refuel(double addedFuel)
        {
            var newFuelQuantity = this.litersFuel + addedFuel;
            
            if (newFuelQuantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                this.LitersFuel = newFuelQuantity;
            }
            
        }

        public abstract void Drive(double distance);

        public void DriveEmpty(double distance)
        {
            var newFuelLevel = this.LitersFuel - (this.FuelUsage * distance);
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

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.LitersFuel:F2}";
        }
    }
}