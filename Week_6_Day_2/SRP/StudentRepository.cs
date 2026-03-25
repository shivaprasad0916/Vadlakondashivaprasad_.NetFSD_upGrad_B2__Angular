using System;
using System.Collections.Generic;
using System.Text;

public class StudentRepository
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student '{student.StudentName}' added successfully.");
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetStudentById(int id)
    {
        return students.Find(s => s.StudentId == id);
    }
}
