namespace _08.WeakStudents
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
    public class WeakStudents
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
            var result = list.Where(x => x.Marks.Where(s => s <= 3).Count() >= 2);
            Console.WriteLine(String.Join("\n", result));
        }
    }
}
