using System;
using System.Linq;

namespace NumbersInReversedOrder
{
    class Program
    {
        class DecimalNumber
        {
            public decimal Value { get; set; }

            public DecimalNumber(decimal value)
            {
                this.Value = value;
            }

            public void PrintReversedDigits()
            {
                var digits = this.Value.ToString().ToCharArray().ToList();
                digits.Reverse();
                Console.WriteLine(string.Join("", digits));
            }
        }
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());

            var number = new DecimalNumber(n);
            number.PrintReversedDigits();
        }
    }
}
