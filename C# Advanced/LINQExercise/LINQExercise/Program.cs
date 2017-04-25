using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercise
{
    class Student
    {
        public string FN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public int Group { get; set; }

        public int[] Grades { get; set; }

        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{string.Join(" ", Grades)}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var lines = File.ReadAllLines(@"../../Seed/StudentData.txt").Skip(1);
            //var students = new List<Student>();
            //foreach (var line in lines)
            //{
            //    var studentsParams = line.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            //    students.Add(new Student()
            //    {
            //        FN = studentsParams[0],
            //        FirstName = studentsParams[1],
            //        LastName = studentsParams[2],
            //        Email = studentsParams[3],
            //        Age = int.Parse(studentsParams[4]),
            //        Group = int.Parse(studentsParams[5]),
            //        Grades = new []{int.Parse(studentsParams[6]), int.Parse(studentsParams[7]), int.Parse(studentsParams[8]), int.Parse(studentsParams[9])},
            //        Phone = studentsParams[10]
            //    });
            //}

            //StudentsByGroup();
            //StudentsByFirstLastName();
            //StudentsByAge();
            //SortStudents();
            //FilterStudentsByEmailDomain();
            //ByPhone();
            //ExcellentStudents();
            //WeakStudents();
            //StudentsEnrolledIn2014or2015();

        }

        private static void GroupByGroup()
        {
            throw new NotImplementedException();
        }

        private static void StudentsEnrolledIn2014or2015()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FN = input[0],
                    Grades = input.Skip(1).Select(int.Parse).ToArray()
                };
                students.Add(student);
            }
            var secondGroupStudents = students
                .Where(s => 
                s.FN.Substring(s.FN.Length-2, 2) == "14"||
                s.FN.Substring(s.FN.Length - 2, 2) == "15"
                );
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void WeakStudents()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grades = input.Skip(2).Select(int.Parse).ToArray()
                };
                students.Add(student);
            }
            var secondGroupStudents = students
                .Where(s => s.Grades.Where(g => g <= 3).Count() >= 2);
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void ExcellentStudents()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Grades = input.Skip(2).Select(int.Parse).ToArray()
                };
                students.Add(student);
            }
            var secondGroupStudents = students
                .Where(s => s.Grades.Any(g => g == 6));
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void ByPhone()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Phone = input[2]
                };
                students.Add(student);
            }
            var secondGroupStudents = students
                .Where(s => s.Phone.Substring(0,2) == "02" || s.Phone.Substring(0, 5) == "+3592");
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void FilterStudentsByEmailDomain()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Email = input[2]
                };
                students.Add(student);
            }
            var secondGroupStudents = students.Where(s => s.Email.Split('@').Last() == "gmail.com");
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void SortStudents()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1]
                };
                students.Add(student);
            }
            var secondGroupStudents = students.OrderBy(s => s.LastName).ThenByDescending(s => s.FirstName);
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void StudentsByAge()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Age = int.Parse(input[2])
                };
                students.Add(student);
            }
            var secondGroupStudents = students.Where(s => s.Age >= 18 && s.Age<=24);
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void StudentsByFirstLastName()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1]
                };
                students.Add(student);
            }
            var secondGroupStudents = students.Where(s => string.Compare(s.FirstName, s.LastName) < 0).ToList();
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }
        }

        private static void StudentsByGroup()
        {
            var students = new List<Student>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "END")
                {
                    break;
                }
                var student = new Student()
                {
                    FirstName = input[0],
                    LastName = input[1],
                    Group = int.Parse(input[2])
                };
                students.Add(student);
            }
            var secondGroupStudents = students.Where(s => s.Group == 2).OrderBy(s => s.FirstName);
            foreach (var ss in secondGroupStudents)
            {
                Console.WriteLine(ss);
            }

        }
    }
}
