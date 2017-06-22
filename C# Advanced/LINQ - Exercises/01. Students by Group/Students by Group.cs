namespace _01.Students_by_Group
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Group { get; set; }
        public Student(string firstName, string secondName, int group)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Group = group;
        }
        public override string ToString()
        {
            return this.FirstName + " " + this.SecondName;
        }
    }
    public class StudentsByGroup
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
            Console.WriteLine(String.Join("\n", list.Where(a => a.Group == 2).OrderBy(a => a.FirstName)));
        }
    }
}
