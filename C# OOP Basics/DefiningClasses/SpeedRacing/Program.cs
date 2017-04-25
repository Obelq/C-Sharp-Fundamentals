using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model, double amount, double cost)
        {
            this.Model = model;
            this.FuelAmount = amount;
            this.FuelCost = cost;
            this.DistanceTravelled = 0;
        }
        public string Model  { get; set; }

        public double FuelAmount { get; set; }

        public double FuelCost { get; set; }

        public double DistanceTravelled { get; set; }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTravelled}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var model = input[0];
                var fuelAmount = input[1];
                var fuelCost = input[2];
                var car = new Car(model, double.Parse(fuelAmount), double.Parse(fuelCost));
                cars.Add(car);
            }

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var command = input[0];
                if (command == "End")
                {
                    break;
                }
                var model = input[1];
                var distanceToTravel = int.Parse(input[2]);
                var car = cars.Single(c => c.Model == model);
                var fuelBalance = car.FuelAmount / car.FuelCost - distanceToTravel;

                if (fuelBalance >= 0)
                {
                    car.FuelAmount -= distanceToTravel * car.FuelCost;
                    car.DistanceTravelled += distanceToTravel;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
