using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Insurance_Policy_Management_System
    {
        public static void Main(string[] args)
        {
            Policy p1 = new Policy("POL101", "Sajal", DateTime.Now.AddDays(15), "Health");
            Policy p2 = new Policy("POL102", "Rahul", DateTime.Now.AddDays(45), "Auto");
            Policy p3 = new Policy("POL103", "Priya", DateTime.Now.AddDays(10), "Health");
            Policy p4 = new Policy("POL101", "Sajal Duplicate", DateTime.Now.AddDays(20), "Health");

            HashSet<string> uniquePolicyNums = new HashSet<string>();
            LinkedList<Policy> insertionOrderPolicies = new LinkedList<Policy>();
            SortedSet<Policy> sortedPolicies = new SortedSet<Policy>();

            Policy[] allPolicies = new Policy[] { p1, p2, p3, p4 };
            foreach (Policy pol in allPolicies)
            {
                if (!uniquePolicyNums.Contains(pol.policyNumber))
                {
                    uniquePolicyNums.Add(pol.policyNumber);
                    insertionOrderPolicies.AddLast(pol);
                    sortedPolicies.Add(pol);
                }
                else
                {
                    Console.WriteLine($"Duplicate policy detected with number {pol.policyNumber}");
                }
            }

            Console.WriteLine("\nAll Unique Policies in Insertion Order:");
            foreach (Policy pol in insertionOrderPolicies)
            {
                pol.Display();
            }

            Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
            foreach (Policy pol in sortedPolicies)
            {
                if (pol.expiryDate <= DateTime.Now.AddDays(30))
                {
                    pol.Display();
                }
            }

            Console.WriteLine("\nPolicies with Health Coverage:");
            foreach (Policy pol in insertionOrderPolicies)
            {
                if (pol.coverageType == "Health")
                {
                    pol.Display();
                }
            }
        }
    }

    public class Policy : IComparable<Policy>
    {
        public string policyNumber;
        public string holderName;
        public DateTime expiryDate;
        public string coverageType;

        public Policy (string policyNumber, string holderName, DateTime expiryDate, string coverageType)
        {
            this.policyNumber = policyNumber;
            this.holderName = holderName;
            this.expiryDate = expiryDate;
            this.coverageType = coverageType;
        }

        public void Display()
        {
            Console.WriteLine($"Policy {policyNumber} owned by {holderName} expires on {expiryDate.ToShortDateString()} with coverage {coverageType}");
        }

        public int CompareTo(Policy? other)
        {
            if (other == null) return 1;
            int result = this.expiryDate.CompareTo(other.expiryDate);
            if (result == 0)
            {
                return this.policyNumber.CompareTo(other.policyNumber);
            }
            return result;
        }
    }
}
