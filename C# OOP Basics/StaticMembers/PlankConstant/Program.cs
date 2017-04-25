﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlankConstant
{
    public class Calculation
    {
        public static double planckConstant = double.Parse("6.62606896e-34", System.Globalization.NumberStyles.Float);
        public static double pi = 3.14159;

        public static double Calculate()
        {
            return planckConstant / (2 * pi);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.Calculate());
        }
    }
}
