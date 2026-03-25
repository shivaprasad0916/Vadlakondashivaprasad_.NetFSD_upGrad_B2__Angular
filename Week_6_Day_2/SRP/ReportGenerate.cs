using System;
using System.Collections.Generic;
using System.Text;

// ReportGenerator - only handles printing/reporting
public class ReportGenerator
{
    public void PrintReport(List<Student> students)
    {
        Console.WriteLine("\n===== Student Report =====");
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.StudentId} | Name: {s.StudentName} | Course: {s.Course}");
        }
        Console.WriteLine();
    }
}
