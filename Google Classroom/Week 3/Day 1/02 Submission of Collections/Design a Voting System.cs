using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_1._02_Submission_of_Collections
{
    internal class Design_a_Voting_System
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> voteCounts = new Dictionary<string, int>();
            LinkedList<string> voteOrder = new LinkedList<string>();

            string[] castVotes = new string[] { "Alice", "Bob", "Alice", "Charlie", "Bob", "Alice" };

            foreach (string candidate in castVotes)
            {
                voteOrder.AddLast(candidate);
                if (voteCounts.ContainsKey(candidate))
                {
                    voteCounts[candidate]++;
                }
                else
                {
                    voteCounts[candidate] = 1;
                }
            }

            Console.WriteLine("Order of Votes Cast:");
            foreach (string candidate in voteOrder)
            {
                Console.Write($"{candidate} ");
            }
            Console.WriteLine();

            SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>(voteCounts);
            Console.WriteLine("\nSorted Voting Results (by Candidate Name):");
            foreach (KeyValuePair<string, int> entry in sortedResults)
            {
                Console.WriteLine($"Candidate {entry.Key} received {entry.Value} votes");
            }
        }
    }
}
