using System;
using System.Data;

namespace Encapsulation
{
    internal class BankManagementSystem
    {
        class BankAccount
        {
            private double balance;
            
            public void Deposite(double deposite)
            {
                balance = deposite + balance;
            }

            public void Withdrawal(double withdrawal)
            {
                if(withdrawal > balance)
                {
                    Console.WriteLine($"Insufficiant Balance!.....");
                }
                else
                {
                    balance = balance - withdrawal;
                }
            }
            public double GetBalance()
            {
                return balance; 
            }
        }
        static void Main()
        {
            BankAccount bankAccount = new BankAccount();
            Console.Write("Enter Deposite Amount: ");
            double depositeBalance = Convert.ToDouble(Console.ReadLine());

            bankAccount.Deposite(depositeBalance);

            Console.Write("Enter Withdrawal Amount: ");
            double withdrawalBalance = Convert.ToDouble(Console.ReadLine());

            bankAccount.Withdrawal(withdrawalBalance);

            Console.WriteLine($"Current Balance: {bankAccount.GetBalance()}");
        }
    }
}
