using System;
using System.Collections.Generic;

namespace Week_4_Day_5
{
    internal class BankAccounts
    {
        class BankAccount
        {
            //Private balance
            private double Balance;

            //diposite method
            public void Depoite(int dipositeAmount)
            {
                Balance = Balance + dipositeAmount;
                Console.WriteLine($"Deposited : {dipositeAmount}");
            }
          
            //withdrawal Method
            public void Withdrawal(int WithdrawalAmount)
            {
                if(Balance >= WithdrawalAmount)
                {
                    Balance = Balance - WithdrawalAmount;
                    Console.WriteLine($"Withdrawal Amount : {WithdrawalAmount}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }

            //GetBalannce Method
            public double GetBalance()
            {
                return Balance;
            }
        }
      static void Main()
        {
            BankAccount BA = new BankAccount();
            Console.Write("Enter the Deposite AMount : ");
            int dipositeAmount = Convert.ToInt32(Console.ReadLine());
            BA.Depoite(dipositeAmount);

            Console.Write("Enter the Withdrawal Amount : ");
            int WithdrawalAmount = Convert.ToInt32(Console.ReadLine());
            BA.Withdrawal(WithdrawalAmount);

            Console.WriteLine($"Current Balance : {BA.GetBalance()}");

        }
    }
}
