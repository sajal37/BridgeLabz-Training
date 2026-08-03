using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Bank_Account_Types
    {
        public void Demo()
        {
            SavingsAccount sa = new SavingsAccount("SA1001", 50000, 4.5);
            CheckingAccount ca = new CheckingAccount("CA2001", 30000, 5000);
            FixedDepositAccount fda = new FixedDepositAccount("FD3001", 100000, 6.5, 12);

            sa.DisplayAccountType();
            ca.DisplayAccountType();
            fda.DisplayAccountType();
        }
    }

    class BankAccount
    {
        protected string AccountNumber;
        protected double Balance;

        public BankAccount (string accNum, double balance)
        {
            this.AccountNumber = accNum;
            this.Balance = balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
        }
    }

    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount (string accNum, double balance, double rate) : base(accNum, balance)
        {
            this.interestRate = rate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Savings Account - Account Number: {AccountNumber}, Balance: {Balance}, Interest Rate: {interestRate}%");
        }
    }

    class CheckingAccount : BankAccount
    {
        private double WithdrawalLimit;

        public CheckingAccount (string accNum, double balance, double limit) : base(accNum, balance)
        {
            this.WithdrawalLimit = limit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Checking Account - Account Number: {AccountNumber}, Balance: {Balance}, Withdrawal Limit: {WithdrawalLimit}");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        private double interestRate;
        private int TenureMonths;

        public FixedDepositAccount (string accNum, double balance, double rate, int tenure) : base(accNum, balance)
        {
            this.interestRate = rate;
            this.TenureMonths = tenure;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"Fixed Deposit Account - Account Number: {AccountNumber}, Balance: {Balance}, Interest Rate: {interestRate}%, Tenure: {TenureMonths} months");
        }
    }
}
