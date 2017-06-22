namespace _09.Students_Enrolled_in_2014_or_2015
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FacultyNumber { get; set; }
        public List<int> Marks { get; set; }
        public Student(string facultyNumber, List<int> marks)
        {
            this.FacultyNumber = facultyNumber;
            this.Marks = marks;
        }
        public override string ToString()
        {
            return $"{string.Join(" ",this.Marks)}";
        }
    }
    public class StudentsEnrolledIn2014or2015
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
                var student = new Student(line[0], line.Skip(1).Select(int.Parse).ToList());

                list.Add(student);
            }
            var result = list.Where(x => x.FacultyNumber.EndsWith("14") || x.FacultyNumber.EndsWith("15")).ToList();
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
