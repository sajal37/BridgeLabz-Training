using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Implement_a_Banking_System
    {
        public static void Main(string[] args)
        {
            Dictionary<int, double> balances = new Dictionary<int, double>();
            balances[1001] = 50000;
            balances[1002] = 25000;
            balances[1003] = 75000;

            Queue<WithdrawalRequest> requests = new Queue<WithdrawalRequest>();
            requests.Enqueue(new WithdrawalRequest(1001, 5000));
            requests.Enqueue(new WithdrawalRequest(1002, 30000));
            requests.Enqueue(new WithdrawalRequest(1003, 10000));

            Console.WriteLine("Processing Withdrawal Requests:");
            while (requests.Count > 0)
            {
                WithdrawalRequest req = requests.Dequeue();
                if (balances.ContainsKey(req.accountNumber))
                {
                    double currentBal = balances[req.accountNumber];
                    if (currentBal >= req.amount)
                    {
                        balances[req.accountNumber] -= req.amount;
                        Console.WriteLine($"Withdrawal of {req.amount} successful for account {req.accountNumber}. New Balance: {balances[req.accountNumber]}");
                    }
                    else
                    {
                        Console.WriteLine($"Withdrawal failed for account {req.accountNumber}: Insufficient balance");
                    }
                }
            }

            SortedDictionary<double, int> sortedByBalance = new SortedDictionary<double, int>();
            foreach (KeyValuePair<int, double> entry in balances)
            {
                sortedByBalance[entry.Value] = entry.Key;
            }

            Console.WriteLine("\nCustomers Sorted by Balance:");
            foreach (KeyValuePair<double, int> entry in sortedByBalance)
            {
                Console.WriteLine($"Account {entry.Value} has balance {entry.Key}");
            }
        }
    }

    class WithdrawalRequest
    {
        public int accountNumber;
        public double amount;

        public WithdrawalRequest (int accountNumber, double amount)
        {
            this.accountNumber = accountNumber;
            this.amount = amount;
        }
    }
}
