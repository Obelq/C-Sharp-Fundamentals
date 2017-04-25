using System;
using System.Linq;
using System.Reflection;

namespace ClassBox
{
    class Box
    {
        private double height;

        private double width;

        private double length;

        public Box(double length, double width, double height)
        {
            this.height = height;
            this.length = length;
            this.Width = width;
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    //throw new ArgumentException("Width cannot be zero or negative
                    Console.WriteLine("Width cannot be zero or negative.");
                    return;
                }
                width = value;
            }
        }

        public double GetLateralSurfaceArea()
        {
            double area = 2 * height * length + 2 * height * width;
            return area;
        }
        public double GetVolume()
        {
            double volume = height * length * width;
            return volume;
        }
        public double GetSurfaceArea()
        {
            double area = 2 * height * length + 2 * height * width + 2 * width * length;
            return area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            Console.WriteLine(fields.Count());

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(length, width, height);

            if (box.Width == 0)
            {
                return;
            }
            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.GetVolume():F2}");

        }
    }
}
