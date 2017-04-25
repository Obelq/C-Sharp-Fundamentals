using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public string Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{this.Model}:\n  {this.Engine}\n  Weight: {this.Weight}\n  Color: {this.Color}";
        }
    }

    class Engine
    {
        public Engine(string model, string power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
        public string Model { get; set; }

        public string Power { get; set; }

        public string Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            return $"{this.Model}:\n{new string(' ', 4)}Power: {this.Power}\n{new string(' ', 4)}Displacement: {this.Displacement}\n{new string(' ', 4)}Efficiency: {this.Efficiency}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new []{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = input[0];
                var power = input[1];
                var engine = new Engine(model, power);
                if (input.Length > 2)
                {
                    double displacementNumber;
                    var isDisplacement = double.TryParse(input[2], out displacementNumber);
                    if (isDisplacement)
                    {
                        engine.Displacement = input[2];
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                    if (input.Length == 4)
                    {
                        if (isDisplacement)
                        {
                            engine.Efficiency = input[3];
                        }
                        else
                        {
                            engine.Displacement = input[3];
                        }
                    }
                }
                engines.Add(engine);
            }


            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var model = input[0];
                var engineModel = input[1];
                Engine engine = engines.SingleOrDefault(e => e.Model == engineModel);
                var car = new Car(model, engine);
                if (input.Length > 2)
                {
                    double testNumber;
                    var isWeight = double.TryParse(input[2], out testNumber);
                    if (isWeight)
                    {
                        car.Weight = input[2];
                    }
                    else
                    {
                        car.Color = input[2];
                    }
                    if (input.Length == 4)
                    {
                        if (isWeight)
                        {
                            car.Color = input[3];
                        }
                        else
                        {
                            car.Weight = input[3];
                        }
                    }
                }
                cars.Add(car);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
