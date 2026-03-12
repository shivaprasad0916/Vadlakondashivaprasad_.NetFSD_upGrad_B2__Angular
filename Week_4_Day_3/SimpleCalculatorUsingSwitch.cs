using System;

namespace Week_4_Day_3
{
    internal class SimpleCalculatorUsingSwitch
    {
        static void Main()
        {
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Result: " + result);
                    break;

                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
        }
    }
}
