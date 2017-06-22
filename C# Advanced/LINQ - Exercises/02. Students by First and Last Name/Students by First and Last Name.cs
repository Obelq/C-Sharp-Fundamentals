namespace _02.Students_by_First_and_Last_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Student(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}";
        }
    }
    public class StudentsByGroup
    {
        public static void Main()
        {

            var list = new List<Student>();
            while (true)
            {
                var line = Console.ReadLine().Split(new[] { ' ', '\t' },StringSplitOptions.RemoveEmptyEntries).ToList();
                if (line[0] == "END")
                {
                    break;
                }
                var student = new Student(line[0], line[1]);

                list.Add(student);
            }
            Console.WriteLine(String.Join("\n", list.Where(a => a.FirstName.Length > 0 && a.SecondName.Length > 0 && char.ToLower(a.FirstName[0]).CompareTo(char.ToLower(a.SecondName[0])) < 0)));
        }
    }
}

