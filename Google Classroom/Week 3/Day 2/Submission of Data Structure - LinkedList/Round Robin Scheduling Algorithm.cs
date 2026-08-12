using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Round_Robin_Scheduling_Algorithm
    {
        public static void Main(string[] args)
        {
            RoundRobinScheduler scheduler = new RoundRobinScheduler();

            scheduler.AddProcess(1, 10, 1);
            scheduler.AddProcess(2, 5, 2);
            scheduler.AddProcess(3, 8, 1);

            Console.WriteLine("Initial Processes in Queue:");
            scheduler.DisplayQueue();

            int quantum = 4;
            Console.WriteLine($"\nSimulating Round Robin Scheduling with Time Quantum = {quantum}:");
            scheduler.Simulate(quantum);
        }
    }

    class ProcessNode
    {
        public int processId;
        public int burstTime;
        public int remTime;
        public int priority;
        public int completionTime;
        public int waitingTime;
        public int turnAroundTime;
        public ProcessNode next;

        public ProcessNode (int pid, int burstTime, int priority)
        {
            this.processId = pid;
            this.burstTime = burstTime;
            this.remTime = burstTime;
            this.priority = priority;
            this.next = null;
        }
    }

    class RoundRobinScheduler
    {
        private ProcessNode head;
        private ProcessNode tail;
        private int totalProcesses = 0;

        public void AddProcess(int pid, int burstTime, int priority)
        {
            ProcessNode newNode = new ProcessNode(pid, burstTime, priority);
            if (head == null)
            {
                head = tail = newNode;
                newNode.next = head;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = head;
            }
            totalProcesses++;
        }

        public void DisplayQueue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            ProcessNode temp = head;
            do
            {
                Console.WriteLine($"PID: {temp.processId}, Burst Time: {temp.burstTime}, Remaining: {temp.remTime}, Priority: {temp.priority}");
                temp = temp.next;
            } while (temp != head);
        }

        public void Simulate(int quantum)
        {
            if (head == null) return;

            int currentTime = 0;
            int activeCount = totalProcesses;
            ProcessNode curr = head;

            List<ProcessNode> completed = new List<ProcessNode>();

            while (activeCount > 0)
            {
                if (curr.remTime > 0)
                {
                    int executeTime = (curr.remTime > quantum) ? quantum : curr.remTime;
                    curr.remTime -= executeTime;
                    currentTime += executeTime;

                    Console.WriteLine($"Process {curr.processId} executed for {executeTime} units. Remaining Burst: {curr.remTime} (Current Time: {currentTime})");

                    if (curr.remTime == 0)
                    {
                        curr.completionTime = currentTime;
                        curr.turnAroundTime = curr.completionTime;
                        curr.waitingTime = curr.turnAroundTime - curr.burstTime;
                        completed.Add(curr);
                        activeCount--;
                    }
                }
                curr = curr.next;
            }

            double totalWait = 0;
            double totalTat = 0;

            Console.WriteLine("\nExecution Completed. Process Performance:");
            foreach (ProcessNode p in completed)
            {
                Console.WriteLine($"Process {p.processId}: Waiting Time = {p.waitingTime}, Turnaround Time = {p.turnAroundTime}");
                totalWait += p.waitingTime;
                totalTat += p.turnAroundTime;
            }

            double avgWait = totalWait / totalProcesses;
            double avgTat = totalTat / totalProcesses;

            Console.WriteLine($"\nAverage Waiting Time: {avgWait}");
            Console.Write($"Average Turnaround Time: {avgTat}");
        }
    }
}
