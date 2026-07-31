using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Bank_Account_Management
    {
        public static void Main(string[] args)
        {
            SavingsAccount sa1 = new SavingsAccount(1001, "Rahul Sharma", 50000);
            sa1.Display();
            sa1.Deposit(10000);
            sa1.Withdraw(5000);
            Console.WriteLine($"Current balance is {sa1.GetBalance()}");
        }
    }
    public class BankAccount
    {
        public int accountNumber;
        protected string accountHolder;
        private double balance;
        public BankAccount (int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount (int accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance)
        {
        }
        public void Display()
        {
            Console.WriteLine($"Account {accountNumber} belongs to {accountHolder} with balance {GetBalance()}");
        }
    }
}
