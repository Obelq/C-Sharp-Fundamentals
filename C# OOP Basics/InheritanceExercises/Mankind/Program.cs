using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            protected set
            {
                if (value[0] != Char.ToUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter!Argument: {this.firstName}");
                }
                if (value.Length < 4)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols!Argument: {this.firstName}");
                }

                this.firstName = value;
            }
        }
        public virtual string LastName
        {
            get { return this.lastName; }
            protected set
            {
                if (value[0] != Char.ToUpper(value[0]))
                {
                    throw new ArgumentException($"Expected upper case letter!Argument: {this.lastName}");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException($"Expected length at least 4 symbols!Argument: {this.lastName}");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {this.firstName}\nLast Name: {this.lastName}";
        }
    }

    class Worker : Human
    {
        private double weekSalary;
        private double workHoursPerDay;
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get { return this.weekSalary; }
            protected set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch!Argument: {this.weekSalary}");
                }
                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch!Argument: {this.workHoursPerDay}");
                }
                this.workHoursPerDay = value;
            }
        }

        public double SalaryPerHour
        {
            get { return this.weekSalary / (5 * this.workHoursPerDay); }
        }

        public override string LastName
        {
            get { return base.LastName; }
            protected set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException($"Expected length more than 3 symbols!Argument: {this.LastName}");
                }
                base.LastName = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\nWeek Salary: {this.weekSalary:F2}\nHours per day: {this.workHoursPerDay:F2}\nSalary per hour: {this.SalaryPerHour:F2}";
        }


    }

    class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            protected set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException($"Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nFaculty number: {this.facultyNumber}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string firstName = tokens[0];
            string lastName = tokens[1];
            string facultyNumber = tokens[2];
            Student student;
            try
            {
                student = new Student(firstName, lastName, facultyNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            input = Console.ReadLine();
            tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            firstName = tokens[0];
            lastName = tokens[1];
            double weekSalary = double.Parse(tokens[2]);
            double hoursPerDay = double.Parse(tokens[3]);

            Worker worker;
            try
            {
                worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Console.WriteLine(student);
            Console.WriteLine();
            Console.WriteLine(worker);
            Console.WriteLine();
        }
    }
}
