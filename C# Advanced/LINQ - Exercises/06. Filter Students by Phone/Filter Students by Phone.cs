namespace _06.Filter_Students_by_Phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<int> Marks { get; set; }
        public Student(string firstName, string secondName, List<int> marks)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Marks = marks;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}";
        }
    }
    public class FilterStudentsByPhone
    {
        public static void Main(string[] args)
        {
            var list = new List<Student>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                if (line[0] == "END")
                {
                    break;
                }
                var student = new Student(line[0], line[1], line.Skip(2).Select(int.Parse).ToList());

                list.Add(student);
            }
            Console.WriteLine(String.Join("\n", list.Where(x => x.Marks.Any(s => s == 6))));
        }
    }
}
