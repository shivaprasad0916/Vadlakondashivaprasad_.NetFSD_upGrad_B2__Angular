using System;
using System.Collections.Generic;
using System.Text;

class Program1
{
    static void Main()
    {
        StudentRepository repo = new StudentRepository();
        repo.AddStudent(new Student(1, "Rahul", "CSE"));
        repo.AddStudent(new Student(2, "Shiva", "EEE"));
        repo.AddStudent(new Student(3, "Mahesh", "ECE"));

        ReportGenerator report = new ReportGenerator();
        report.PrintReport(repo.GetAllStudents());
    }
}
