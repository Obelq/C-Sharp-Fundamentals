using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires )
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }


        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }
    }

    public class Cargo
    {
        public Cargo(int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
        public int Weight { get; set; }

        public string Type { get; set; }
    }

    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }

        public int Power { get; set; }
    }

    public class Tire
    {
        public Tire(double pressure, int age)
        {
            this.Perssure = pressure;
            this.Age = age;
        }
        public double Perssure { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var model = input[0];
                var eSpeed = int.Parse(input[1]);
                var ePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var tPressure1 = double.Parse(input[5]);
                var tAge1 = int.Parse(input[6]);
                var tPressure2 = double.Parse(input[7]);
                var tAge2 = int.Parse(input[8]);
                var tPressure3 = double.Parse(input[9]);
                var tAge3 = int.Parse(input[10]);
                var tPressure4 = double.Parse(input[11]);
                var tAge4 = int.Parse(input[12]);

                Car car = new Car(
                    model,
                    new Engine(eSpeed,ePower),
                    new Cargo(cargoWeight, cargoType),
                    new List<Tire>()
                    {
                        new Tire(tPressure1, tAge1),
                        new Tire(tPressure2, tAge2),
                        new Tire(tPressure3, tAge3),
                        new Tire(tPressure4, tAge4)
                    });
                cars.Add(car);
            }
            var cargoTypeRequired = Console.ReadLine();
            List<Car> result;
            if (cargoTypeRequired == "fragile")
            {
                result = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Perssure < 1))
                    .ToList();
            }
            else
            {
                result = cars
                    .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .ToList();
            }
            foreach (var car in result)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
