using System;
using System.Collections.Generic;
using System.Text;

class Program7
{
    static void Main()
    {
        IStudentRepository repo = new StudentRepository();
        StudentService service = new StudentService(repo);

        service.EnrollStudent(1, "Alice", "C#");
        service.EnrollStudent(2, "Bob", "Java");
        service.EnrollStudent(3, "Charlie", "Python");

        service.DisplayAllStudents();

        service.FindStudent(2);

        service.RemoveStudent(2);

        service.DisplayAllStudents();
    }
}
