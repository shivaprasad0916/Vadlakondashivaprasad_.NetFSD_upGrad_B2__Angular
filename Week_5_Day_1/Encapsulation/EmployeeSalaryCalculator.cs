using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace Encapsulation
{
    internal class EmployeeSalaryCalculator
    {
        class Employee
        {
            public string Name { get; set; }
            public double BaseSalary { get; set; }

            public virtual double SalaryCalculator()
            {
                return BaseSalary;
            }
        }
        class Manager : Employee
        {
            public override double SalaryCalculator()
            {
                return BaseSalary + (BaseSalary * 0.2);
            }
        }
        class Developer : Employee
        {
            public override double SalaryCalculator()
            {
                return BaseSalary + (BaseSalary * 0.1);

            }
        }
        static void Main()
        {
            Employee manager = new Manager();

            Console.Write("Enter Base Salary: ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());
            manager.Name = "Manager";
            manager.BaseSalary = baseSalary;

            Employee developer = new Developer();
            developer.Name = "Developer";
            developer.BaseSalary = baseSalary;

            Console.WriteLine($"Manager Salary: {manager.SalaryCalculator()}");
            Console.WriteLine($"Developer Salary: {developer.SalaryCalculator()}");
        }
    }
}
