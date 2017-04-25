using System;
using System.Reflection;

namespace MathodSaysHello
{
    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name;

        public string SayHello()
        {
            return $"{this.Name} says \"Hello\"!";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] methods = personType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

            if (fields.Length != 1 || methods.Length != 5)
            {
                throw new Exception();
            }

            string personName = Console.ReadLine();
            Person person = new Person(personName);

            Console.WriteLine(person.SayHello());

        }
    }
}
