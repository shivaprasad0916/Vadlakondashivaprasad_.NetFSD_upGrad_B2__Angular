using System;
using System.Collections.Generic;
using System.Linq;


internal class SafeDivisionCalculator
{
    class Calculator
    {
        public void Divide(double numerator, double denominator)
        {
            try
            {
                double result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot Divide By Zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operation Completed Safely");
            }
        }
    }
    class Solution
    {
        static void Main()
        {
            Calculator cal = new Calculator();

            Console.Write("Enter Numerator: ");
            double numa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Denominator: ");
            double deno = Convert.ToDouble(Console.ReadLine());

            cal.Divide(numa, deno);
        }
    }
}

