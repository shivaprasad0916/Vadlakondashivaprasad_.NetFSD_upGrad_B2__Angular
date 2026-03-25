using System;
using System.Collections.Generic;

// Entity class - only holds data
public class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string Course { get; set; }

    public Student(int id, string name, string course)
    {
        StudentId = id;
        StudentName = name;
        Course = course;
    }
}