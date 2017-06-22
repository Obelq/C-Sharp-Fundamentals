namespace _05.Filter_Students_by_Email_Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public Student(string firstName, string secondName, string email)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Email = email;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}";
        }
    }
    public class FiliterStudentsByEmailDomain
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
                var student = new Student(line[0], line[1], line[2]);

                list.Add(student);
            }
            Console.WriteLine(String.Join("\n", list.Where(x => x.Email.EndsWith("@gmail.com"))));
        }
    }
}
  