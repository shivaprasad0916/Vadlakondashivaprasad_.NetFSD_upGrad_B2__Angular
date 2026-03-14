using System;


namespace Week_4_Day_4
{
    internal class StudentGradeCalculator
    {
        class Student
        {
            public double CalculateAverage(double M1, double M2, double M3, double M4)
            {
                double Average = (M1+M2+M3+M4)/4;
                return Average;
            }
        }
        static void Main()
        {
            Student S = new Student();

            Console.Write("Enter English Marks: ");
            double M1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Maths Marks: ");
            double M2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Science Marks: ");
            double M3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Computer Marks: ");    
            double M4 = Convert.ToDouble(Console.ReadLine());

            double avg = S.CalculateAverage(M1, M2, M3, M4);

            Console.WriteLine($"Average Marks: {avg}");


            // Grade Calculation
            if (avg > 80 && avg <= 100)
            {
                Console.WriteLine("GRADE: A");
            }
            else if (avg > 60 && avg <= 80)
            {
                Console.WriteLine("GRADE: B");
            }
            else if (avg > 40 && avg <= 60)
            {
                Console.WriteLine("GRADE: C");
            }
            else if (avg > 0 && avg <= 40)
            {
                Console.WriteLine("GRADE: F");
            }
        }
    }
}
