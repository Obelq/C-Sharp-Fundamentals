using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrariTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var driverName = Console.ReadLine();
            var ferrari = new Ferrari(driverName);
            Console.WriteLine(ferrari);

            string ferrariName = typeof(Ferrari).Name;
            string iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }

        }
    }
}
