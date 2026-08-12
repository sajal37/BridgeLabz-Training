using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Student_Record_Management
    {
        public static void Main(string[] args)
        {
            StudentLinkedList list1 = new StudentLinkedList();

            list1.AddAtEnd(101, "Rahul", 20, "A");
            list1.AddAtBeginning(100, "Amit", 19, "B");
            list1.AddAtPosition(102, "Priya", 21, "A+", 3);

            Console.WriteLine("All Student Records:");
            list1.DisplayAll();

            Console.WriteLine("\nSearching for Roll Number 101:");
            list1.Search(101);

            Console.WriteLine("\nUpdating Grade for Roll Number 100 to A:");
            list1.UpdateGrade(100, "A");

            Console.WriteLine("\nDeleting Student with Roll Number 101:");
            list1.DeleteByRoll(101);

            Console.WriteLine("\nStudent Records After Deletion:");
            list1.DisplayAll();
        }
    }

    class StudentNode
    {
        public int roll;
        public string name;
        public int age;
        public string grade;
        public StudentNode next;

        public StudentNode (int roll, string name, int age, string grade)
        {
            this.roll = roll;
            this.name = name;
            this.age = age;
            this.grade = grade;
            this.next = null;
        }
    }

    class StudentLinkedList
    {
        private StudentNode head;

        public void AddAtBeginning(int roll, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(roll, name, age, grade);
            newNode.next = head;
            head = newNode;
        }

        public void AddAtEnd(int roll, string name, int age, string grade)
        {
            StudentNode newNode = new StudentNode(roll, name, age, grade);
            if (head == null)
            {
                head = newNode;
                return;
            }
            StudentNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void AddAtPosition(int roll, string name, int age, string grade, int pos)
        {
            if (pos == 1 || head == null)
            {
                AddAtBeginning(roll, name, age, grade);
                return;
            }
            StudentNode newNode = new StudentNode(roll, name, age, grade);
            StudentNode curr = head;
            int count = 1;
            while (curr.next != null && count < pos - 1)
            {
                curr = curr.next;
                count++;
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }

        public void DeleteByRoll(int roll)
        {
            if (head == null) return;
            if (head.roll == roll)
            {
                head = head.next;
                return;
            }
            StudentNode curr = head;
            while (curr.next != null && curr.next.roll != roll)
            {
                curr = curr.next;
            }
            if (curr.next != null)
            {
                curr.next = curr.next.next;
            }
        }

        public void Search(int roll)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.roll == roll)
                {
                    Console.WriteLine($"Found Student: Roll {temp.roll}, Name {temp.name}, Age {temp.age}, Grade {temp.grade}");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine($"Student with Roll Number {roll} not found.");
        }

        public void UpdateGrade(int roll, string newGrade)
        {
            StudentNode temp = head;
            while (temp != null)
            {
                if (temp.roll == roll)
                {
                    temp.grade = newGrade;
                    Console.WriteLine($"Updated Grade for Roll {roll} to {newGrade}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void DisplayAll()
        {
            StudentNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Roll: {temp.roll}, Name: {temp.name}, Age: {temp.age}, Grade: {temp.grade}");
                temp = temp.next;
            }
            Console.Write("End of Records");
        }
    }
}
