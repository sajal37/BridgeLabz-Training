using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Task_Scheduler
    {
        public static void Main(string[] args)
        {
            CircularTaskScheduler sched1 = new CircularTaskScheduler();

            sched1.AddTaskAtEnd(1, "Database Backup", 1, "2026-08-15");
            sched1.AddTaskAtEnd(2, "Log Rotation", 3, "2026-08-16");
            sched1.AddTaskAtBeginning(3, "Security Audit", 1, "2026-08-14");

            Console.WriteLine("All Scheduled Tasks:");
            sched1.DisplayAll();

            Console.WriteLine("\nViewing current task and moving to next:");
            sched1.ViewCurrentAndNext();
            sched1.ViewCurrentAndNext();

            Console.WriteLine("\nSearching for Tasks with Priority 1:");
            sched1.SearchByPriority(1);

            Console.WriteLine("\nRemoving Task ID 2:");
            sched1.RemoveTask(2);

            Console.WriteLine("\nRemaining Tasks:");
            sched1.DisplayAll();
        }
    }

    class TaskNode
    {
        public int taskId;
        public string taskName;
        public int priority;
        public string dueDate;
        public TaskNode next;

        public TaskNode (int taskId, string taskName, int priority, string dueDate)
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.priority = priority;
            this.dueDate = dueDate;
            this.next = null;
        }
    }

    class CircularTaskScheduler
    {
        private TaskNode head;
        private TaskNode tail;
        private TaskNode current;

        public void AddTaskAtBeginning(int id, string name, int priority, string due)
        {
            TaskNode newNode = new TaskNode(id, name, priority, due);
            if (head == null)
            {
                head = tail = current = newNode;
                newNode.next = head;
                return;
            }
            newNode.next = head;
            head = newNode;
            tail.next = head;
        }

        public void AddTaskAtEnd(int id, string name, int priority, string due)
        {
            TaskNode newNode = new TaskNode(id, name, priority, due);
            if (head == null)
            {
                head = tail = current = newNode;
                newNode.next = head;
                return;
            }
            tail.next = newNode;
            tail = newNode;
            tail.next = head;
        }

        public void RemoveTask(int id)
        {
            if (head == null) return;

            TaskNode currNode = head;
            TaskNode prevNode = tail;

            do
            {
                if (currNode.taskId == id)
                {
                    if (currNode == head && currNode == tail)
                    {
                        head = tail = current = null;
                        return;
                    }
                    if (currNode == head)
                    {
                        head = head.next;
                        tail.next = head;
                    }
                    else if (currNode == tail)
                    {
                        tail = prevNode;
                        tail.next = head;
                    }
                    else
                    {
                        prevNode.next = currNode.next;
                    }
                    if (current == currNode) current = head;
                    return;
                }
                prevNode = currNode;
                currNode = currNode.next;
            } while (currNode != head);
        }

        public void ViewCurrentAndNext()
        {
            if (current == null) return;
            Console.WriteLine($"Current Task: ID {current.taskId}, Name: {current.taskName}, Priority: {current.priority}");
            current = current.next;
        }

        public void SearchByPriority(int priority)
        {
            if (head == null) return;
            TaskNode temp = head;
            do
            {
                if (temp.priority == priority)
                {
                    Console.WriteLine($"Found Task: ID {temp.taskId}, Name {temp.taskName}, Due {temp.dueDate}");
                }
                temp = temp.next;
            } while (temp != head);
        }

        public void DisplayAll()
        {
            if (head == null) return;
            TaskNode temp = head;
            do
            {
                Console.WriteLine($"Task ID: {temp.taskId}, Name: {temp.taskName}, Priority: {temp.priority}, Due: {temp.dueDate}");
                temp = temp.next;
            } while (temp != head);
            Console.Write("End of Schedule");
        }
    }
}
