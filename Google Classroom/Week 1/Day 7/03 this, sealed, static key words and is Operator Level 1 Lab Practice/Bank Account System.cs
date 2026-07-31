using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Bank_Account_System
    {
        public static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Rahul Sharma", 1001);
            BankAccount acc2 = new BankAccount("Priya Singh", 1002);
            DisplayAccountInfo(acc1);
            DisplayAccountInfo(acc2);
            BankAccount.GetTotalAccounts();
        }
        public static void DisplayAccountInfo(object obj)
        {
            if (obj is BankAccount acc)
            {
                acc.Display();
            }
        }
    }
    public class BankAccount
    {
        public static string bankName = "State Bank of India";
        public static int totalAccounts;
        private string accountHolderName;
        public readonly int accountNumber;
        public BankAccount (string accountHolderName, int accountNumber)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            totalAccounts++;
        }
        public void Display()
        {
            Console.WriteLine($"Bank {bankName} account {accountNumber} belongs to {accountHolderName}");
        }
        public static void GetTotalAccounts()
        {
            Console.WriteLine($"Total accounts created are {totalAccounts}");
        }
    }
}
