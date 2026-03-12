using System;

namespace Week_4_Day_3
{
    internal class EmployeeBonusalculator
    {
        static void Main()
        {
            Console.Write("Enter Name: ");
            string Name= Console.ReadLine();

            Console.Write("Enter Salary: ");
            double Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Experience: ");
            int Experience = Convert.ToInt32(Console.ReadLine());
            double Bonus;

            if (Experience < 2)
            {
                Bonus = Salary * 0.05;
            }
            else if (Experience >= 2 && Experience < 5)
            {
                Bonus = Salary * 0.10;
            }
            else if (Experience >= 5)
            {
                Bonus = Salary * 0.15;
            }
            else
            {
                Bonus = 0;
            }

            double FinalSalary = Salary + Bonus;
            Console.WriteLine($"Employee: {Name} \nBonus: {Bonus} \nFinal Salary: {FinalSalary}");
        }
    }
}
