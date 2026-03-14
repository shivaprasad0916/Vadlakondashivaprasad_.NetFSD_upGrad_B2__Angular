using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Day_4
{
    internal class StudentResultAnalyserUsingOutParameter
    {
        class StudentResult
        {
            public double CalculateResult(double M1, double M2, double M3, double M4, out double avg, out double total)
            {
                total = M1 + M2 + M3 + M4;
                avg = total / 4;
                return avg;
            }
        }
        static void Main()
        {
            char choice = 'y';
            do
            {
                StudentResult S = new StudentResult();

                Console.WriteLine("Enter the FOUR subjects Marks: ");
                double M1 = Convert.ToDouble(Console.ReadLine());
                double M2 = Convert.ToDouble(Console.ReadLine());
                double M3 = Convert.ToDouble(Console.ReadLine());
                double M4 = Convert.ToDouble(Console.ReadLine());

                if(M1<0 || M1>100 || M2<0 || M2 > 100 || M3 < 0 || M3 > 100 || M4 < 0 || M4 > 100)
                {
                    Console.WriteLine("Invalid Marks... Please enter marks between 0 and 100.");
                    continue;
                }

                double Total, Average;
                Total = S.CalculateResult(M1, M2, M3, M4, out Average, out Total);
                
                string Status = Average>=40 ? "Pass" : "Fail";

                Console.WriteLine($"Total Marks: {Total} \nAverage Marks: {Average} \n Result Status: {Status}");

                Console.Write("Check another student? (y/n): ");
                choice = Convert.ToChar(Console.ReadLine() ?? "n");
            }while(choice == 'y');
        }
    }
}
