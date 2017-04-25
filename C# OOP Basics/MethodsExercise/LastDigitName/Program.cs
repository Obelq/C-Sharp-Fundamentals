using System;

namespace LastDigitName
{
    class Number
    {
        private readonly string[] _digitsWithWords = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        public int Value { get; set; }

        public Number(int value)
        {
            this.Value = value;
        }

        public string NameOfLastDigit()
        {
            var numToText = this.Value.ToString();
            var lastDigit = int.Parse(numToText[numToText.Length - 1].ToString());
            return _digitsWithWords[lastDigit];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = new Number(n);
            Console.WriteLine(num.NameOfLastDigit().ToLower());
        }
    }
}
