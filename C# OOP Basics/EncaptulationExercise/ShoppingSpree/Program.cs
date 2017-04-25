using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private HashSet<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new HashSet<Product>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get => this.money;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }
            this.Money -= product.Cost;
            this.products.Add(product);
        }

    }
    class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get => this.cost;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cost cannot be negative");
                }
                this.cost = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> product = new Dictionary<string, Product>();

            var allPeople = Console.ReadLine()
                .Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < allPeople.Length; i += 2)
            {
                string name = allPeople[i];
                decimal money = decimal.Parse(allPeople[i + 1]);
                try
                {
                    Person person = new Person(name, money);
                    people.Add(name, person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

            }
            var allProducts = Console.ReadLine()
                .Split(new[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries); ;

            while (true)
            {

            }
        }
    }
}
