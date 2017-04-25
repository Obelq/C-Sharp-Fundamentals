using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;
        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                var name = input[0];
                var salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var employee = new Employee(name, salary, position, department);
                bool isAge;
                if (input.Length == 5 || input.Length == 6)
                {
                    int age;
                    isAge = int.TryParse(input[4], out age);
                    if (isAge)
                    {
                        employee.age = age;
                    }
                    else
                    {
                        employee.email = input[4];
                    }
                    if (input.Length == 6)
                    {
                        if (isAge)
                        {
                            employee.email = input[5];
                        }
                        else
                        {
                            employee.age = int.Parse(input[5]);
                        }
                    }
                }
                employees.Add(employee);                
            }

            var departments = employees
                .GroupBy(e => e.department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)
                })
                .OrderByDescending(d => d.AverageSalary)
                .ToList();
            var maxSalaryDepartment = departments.First();
            Console.WriteLine($"Highest Average Salary: {maxSalaryDepartment.Department}");
            foreach (var e in maxSalaryDepartment.Employees)
            {
                Console.WriteLine($"{e.name} {e.salary:F2} {e.email} {e.age}");
            }


        }
    }
}
