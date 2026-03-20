using System;
using System.Collections.Generic;


internal class StudentRecordManagement
{
    //Define Records
    public record Student(int RollNo, string StudentName, string Course, int Marks);
    public void Main()
    {
        Console.WriteLine("Enter Number of Students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Student[]students = new Student[n];

        //Input Student Details
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\tEnter the Details For Student {i+1} : ");

            int RollNo;
            while (true)
            {
                Console.Write("Enter Roll Number: ");
                if (int.TryParse(Console.ReadLine(), out RollNo) && RollNo > 0)
                    break;
                Console.WriteLine("Invalid Roll Number. Try again.");
            }

            Console.WriteLine("\tEnter the student Name: ");
            string StudentName = Console.ReadLine();

            Console.WriteLine("\tEnter The Course Name: ");
            String Course = Console.ReadLine();

            int Marks;
            while (true)
            {
                Console.Write("Enter Marks: ");
                if (int.TryParse(Console.ReadLine(), out Marks) && Marks >= 0 && Marks <= 100)
                    break;
                Console.WriteLine("Invalid Marks. Enter between 0–100.");
            }
        }

        //Display Records
        Console.WriteLine("\tStudents Records are: ");
        foreach (var stu in students)
        {
            Console.WriteLine($"{stu.RollNo}\t{stu.StudentName}\t{stu.Course}\t{stu.Marks}");
        }

        //Searching Records
        Console.WriteLine("Search Roll Number: ");
        int SearchRoll = Convert.ToInt32(Console.ReadLine());

        bool found = false;
        foreach (var stu in students)
        {
            if(stu.RollNo == SearchRoll)
            {
                Console.WriteLine("Roll Number Found");
                Console.WriteLine($"{stu.RollNo}\t{stu.StudentName}\t{stu.Course}\t{stu.Marks}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine("Invalid Roll NUmber!");
        }
    }
}
