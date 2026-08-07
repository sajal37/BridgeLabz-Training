using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class BankAccount
    {
        private double Balance;

        public BankAccount (double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");
            if (amount > 0)
                Balance = Balance - amount;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
