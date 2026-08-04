using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Banking_System
    {
        public void Demo()
        {
            BankAccount[] accounts = new BankAccount[2];
            accounts[0] = new SavingsAccount("SA1001", "Rahul Verma", 50000);
            accounts[1] = new CurrentAccount("CA2001", "Neha Gupta", 100000);

            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i].Deposit(10000);
                accounts[i].Withdraw(5000);
                Console.WriteLine($"Account: {accounts[i].AccountNumber}");
                Console.WriteLine($"Balance: {accounts[i].Balance}");
                Console.WriteLine($"Interest: {accounts[i].CalculateInterest()}");
                Console.WriteLine();
            }
        }
    }

    interface ILoanable
    {
        void ApplyForLoan(double amount);
        bool CalculateLoanEligibility();
    }

    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        protected double balance;

        public BankAccount (string accNum, string name, double bal)
        {
            this.accountNumber = accNum;
            this.holderName = name;
            this.balance = bal;
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }

        public abstract double CalculateInterest();
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount (string accNum, string name, double bal) : base(accNum, name, bal)
        {
        }

        public override double CalculateInterest()
        {
            return balance * 0.04;
        }

        public void ApplyForLoan(double amount)
        {
            Console.WriteLine($"Loan of {amount} applied");
        }

        public bool CalculateLoanEligibility()
        {
            return balance > 50000;
        }
    }

    class CurrentAccount : BankAccount
    {
        public CurrentAccount (string accNum, string name, double bal) : base(accNum, name, bal)
        {
        }

        public override double CalculateInterest()
        {
            return 0;
        }
    }
}
