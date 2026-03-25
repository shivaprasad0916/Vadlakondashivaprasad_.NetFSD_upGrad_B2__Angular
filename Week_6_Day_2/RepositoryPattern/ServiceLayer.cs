using System;
using System.Collections.Generic;
using System.Text;

public class StudentService
{
    private IStudentRepository _repo;

    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public void EnrollStudent(int id, string name, string course)
    {
        Student student = new Student(id, name, course);
        _repo.Add(student);
    }

    public void RemoveStudent(int id)
    {
        _repo.Delete(id);
    }

    public void DisplayAllStudents()
    {
        var students = _repo.GetAll();
        Console.WriteLine("\n===== All Students =====");
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
        }
        else
        {
            foreach (var s in students)
                Console.WriteLine($"ID: {s.StudentId} | Name: {s.StudentName} | Course: {s.Course}");
        }
        Console.WriteLine("========================\n");
    }

    public void FindStudent(int id)
    {
        Student s = _repo.GetById(id);
        if (s != null)
            Console.WriteLine($"Found -> ID: {s.StudentId} | Name: {s.StudentName} | Course: {s.Course}");
        else
            Console.WriteLine($"Student with ID {id} not found.");
    }
}
