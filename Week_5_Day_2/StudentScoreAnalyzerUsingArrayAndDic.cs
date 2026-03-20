using System;
using System.Collections.Generic;

namespace Week_5_Day_2
{
    internal class StudentScoreAnalyzerUsingArrayAndDic
    {
        static void Main()
        {
            //number of students
            Console.Write("Enter the Number Of Student: ");
            int  size = int.Parse(Console.ReadLine());

            int[] Marks = new int[size];

            //input of marks
             for (int i= 0; i < size; i++)
            {
                Console.Write($"Enter the Marks for Student {i+1} : ");
                int M = int.Parse(Console.ReadLine());
                
                Marks[i] = M;
            }
            //Threshold value
            Console.Write("Enter the Threshold Marks: ");
            double threshold = double.Parse(Console.ReadLine());
            //Total Sum
            double Total = Marks.Sum();

            //Avarage
            double avg = Marks.Average();

            //maximum score
            double highest = Marks.Max();

            //filter Student Above Threshold
            var aboveThreshold = Marks.Where(Mm => Mm > threshold).ToArray();
            int countAboveThreshold = aboveThreshold.Length;

            // Output
            Console.WriteLine("\n--- Results ---");
            Console.WriteLine("Total Marks: " + Total);
            Console.WriteLine("Average Marks: " + avg);
            Console.WriteLine("Students above " + threshold + ": " + countAboveThreshold);
            Console.WriteLine("Highest Score: " + highest);

            Console.WriteLine("\nSubject-wise Highest Marks:");

        }
    }
}
