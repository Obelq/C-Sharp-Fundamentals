namespace _04.Sort_Students
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
    public class SortStudents
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
                var student = new Student(line[0], line[1]);

                list.Add(student);
            }
            Console.WriteLine(String.Join("\n", list.OrderBy(a => a.SecondName).ThenByDescending(a => a.FirstName)));
        }
    }
}
