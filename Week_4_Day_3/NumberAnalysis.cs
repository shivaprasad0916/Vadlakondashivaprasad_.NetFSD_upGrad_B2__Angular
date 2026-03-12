using System;
using System.Diagnostics.Tracing;

namespace Week_4_Day_3
{
    internal class NumberAnalysis
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int EvenCount = 0;
            int OddCount = 0;
            int Sum = 0;

            for (int i = 1; i <= Number; i++)
            {
                if (i % 2 ==0)
                {
                    EvenCount++;
                    Sum = Sum + i;
                }
                else
                {
                    OddCount++;
                    Sum = Sum + i;
                }
            }
            Console.WriteLine($"Even Count: {EvenCount} \nOdd Count: {OddCount} \nSum: {Sum}");
        }
    }
}
