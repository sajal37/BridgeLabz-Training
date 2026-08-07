using System;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class BankAccountTests
    {
        private BankAccount Account;

        [SetUp]
        public void Setup()
        {
            Account = new BankAccount(1000);
        }

        [Test]
        public void Deposit_AddsAmount_IncreasesBalance()
        {
            Account.Deposit(500);
            double Balance = Account.GetBalance();
            Assert.That(Balance, Is.EqualTo(1500));
        }

        [Test]
        public void Withdraw_ValidAmount_DecreasesBalance()
        {
            Account.Withdraw(300);
            double Balance = Account.GetBalance();
            Assert.That(Balance, Is.EqualTo(700));
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            Assert.That(() => Account.Withdraw(1500), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void GetBalance_ReturnsCurrentBalance()
        {
            double Balance = Account.GetBalance();
            Assert.That(Balance, Is.EqualTo(1000));
        }
    }
}
