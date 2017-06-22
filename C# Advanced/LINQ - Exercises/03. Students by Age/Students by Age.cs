namespace _03.Students_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public Student(string firstName, string secondName, int age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName} {this.Age}";
        }
    }
    public class StudentsByAge
    {
        public static void Main()
        {

            var list = new List<Student>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                if (line[0] == "END")
                {
                    break;
                }
                var student = new Student(line[0], line[1], int.Parse(line[2]));

                list.Add(student);
            }
            Console.WriteLine(String.Join("\n", list.Where(a => a.Age >= 18 && a.Age <= 24)));
        }
    }
}

