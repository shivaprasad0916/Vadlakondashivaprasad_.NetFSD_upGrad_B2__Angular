using System;
using System.Collections.Generic;
using System.Text;

// Repository interface (abstraction over data source)
public interface IStudentRepository
{
    void Add(Student student);
    Student GetById(int id);
    List<Student> GetAll();
    void Delete(int id);
}

// Concrete repository - stores data in a List (simulating a DB)
public class StudentRepository : IStudentRepository
{
    private List<Student> _students = new List<Student>();

    public void Add(Student student)
    {
        _students.Add(student);
        Console.WriteLine($"[Repository] Added: {student.StudentName}");
    }

    public Student GetById(int id)
    {
        return _students.Find(s => s.StudentId == id);
    }

    public List<Student> GetAll()
    {
        return _students;
    }

    public void Delete(int id)
    {
        Student s = GetById(id);
        if (s != null)
        {
            _students.Remove(s);
            Console.WriteLine($"[Repository] Deleted: {s.StudentName}");
        }
        else
        {
            Console.WriteLine($"[Repository] Student with ID {id} not found.");
        }
    }
}
