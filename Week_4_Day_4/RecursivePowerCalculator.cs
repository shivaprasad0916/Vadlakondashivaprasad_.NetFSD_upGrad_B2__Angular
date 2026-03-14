using System;

namespace Week_4_Day_4
{
    internal class RecursivePowerCalculator
    {
        class RecursivePower
        {
            public int recpow(int baseNum, int expoNum)
            {
                if (expoNum == 0)
                {
                    return 1;
                }
                else if (expoNum == 1)
                {
                    return baseNum;
                }
                else
                {
                    return baseNum * recpow(baseNum, expoNum - 1);
                }
            }
        }
        static void Main()
            {
                Console.Write("Enter the Base Number: ");
                int baseNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Exponent Number: ");
                int expoNum = Convert.ToInt32(Console.ReadLine());

                RecursivePower R = new RecursivePower();

                int result = R.recpow(baseNum, expoNum);

                Console.WriteLine($"Base Number: {baseNum} \nExponent: {expoNum} \nResult: {result}");
        }
    }
}
