using System;

namespace Week4Day3DotNET
{
    internal class StudentGradeEvaluator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Invalid marks! Please enter marks between 0 and 100.");
                return;
            }

            string grade;

            if (marks >= 90)
                grade = "A";
            else if (marks >= 75)
                grade = "B";
            else if (marks >= 60)
                grade = "C";
            else if (marks >= 50)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine($"Student Name: {name}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}