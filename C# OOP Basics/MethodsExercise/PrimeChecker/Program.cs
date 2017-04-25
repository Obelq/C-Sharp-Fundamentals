using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    public class Number
    {
        public long value;
        public bool isPrime;

        public Number(long value, bool isPrime)
        {
            this.value = value;
            this.isPrime = isPrime;
        }

        public long GetNextPrime()
        {
            long nextNumber = this.value + 1;

            while (true)
            {
                bool isPrime = true;
                if (this.value == 0 || this.value == 1)
                {
                    return this.value + 1;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(nextNumber); i++)
                    {
                        if (nextNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        return nextNumber;
                    }
                }

                nextNumber++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number == 0 || number == 1 || number == 2)
            {
                isPrime = true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Number num = new Number(number, isPrime);
            num.GetNextPrime();
            Console.WriteLine("{0}, {1}", num.GetNextPrime(), num.isPrime ? "true" : "false");
        }
    }
}
