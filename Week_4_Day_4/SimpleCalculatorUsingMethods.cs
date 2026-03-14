using System;
using System.Data;

namespace Week_4_Day_4
{
    internal class SimpleCalculatorUsingMethods
    {
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public int Mul(int a, int b)
            {
                return a * b;
            }
        }
        class Program
        {
            static void Main()
            {
                Console.Write("Enter first Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Second Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Calculator cal = new Calculator();

                int Addition = cal.Add(num1, num2);
                int Subtraction = cal.Sub(num1, num2);
                int Multiplication = cal.Mul(num1, num2);

                Console.WriteLine($"Addition = {Addition}, Subtraction = {Subtraction}, Multiplication = {Multiplication} ");
            }
        }
    }
}
