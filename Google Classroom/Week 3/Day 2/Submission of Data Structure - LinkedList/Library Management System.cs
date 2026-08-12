using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Library_Management_System
    {
        public static void Main(string[] args)
        {
            LibraryDoublyList lib1 = new LibraryDoublyList();

            lib1.AddBookAtEnd("The Alchemist", "Paulo Coelho", "Fiction", 101, true);
            lib1.AddBookAtEnd("Clean Code", "Robert C. Martin", "Tech", 102, true);
            lib1.AddBookAtBeginning("Atomic Habits", "James Clear", "Self Help", 100, false);

            Console.WriteLine("All Books Forward:");
            lib1.DisplayForward();

            Console.WriteLine("\nTotal Books Count:");
            lib1.CountBooks();

            Console.WriteLine("\nUpdating Availability Status for Book ID 100 to Available:");
            lib1.UpdateStatus(100, true);

            Console.WriteLine("\nSearching for Book by Author 'Paulo Coelho':");
            lib1.SearchByAuthor("Paulo Coelho");

            Console.WriteLine("\nDisplaying Books Reverse:");
            lib1.DisplayReverse();

            Console.WriteLine("\nRemoving Book ID 102:");
            lib1.RemoveByBookId(102);

            Console.WriteLine("\nBooks Forward After Removal:");
            lib1.DisplayForward();
        }
    }

    class BookNode
    {
        public string title;
        public string author;
        public string genre;
        public int bookId;
        public bool isAvailable;
        public BookNode prev;
        public BookNode next;

        public BookNode (string title, string author, string genre, int bookId, bool isAvailable)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.bookId = bookId;
            this.isAvailable = isAvailable;
            this.prev = null;
            this.next = null;
        }
    }

    class LibraryDoublyList
    {
        private BookNode head;
        private BookNode tail;

        public void AddBookAtBeginning(string title, string author, string genre, int id, bool status)
        {
            BookNode newNode = new BookNode(title, author, genre, id, status);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }

        public void AddBookAtEnd(string title, string author, string genre, int id, bool status)
        {
            BookNode newNode = new BookNode(title, author, genre, id, status);
            if (tail == null)
            {
                head = tail = newNode;
                return;
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }

        public void RemoveByBookId(int id)
        {
            BookNode curr = head;
            while (curr != null)
            {
                if (curr.bookId == id)
                {
                    if (curr.prev != null) curr.prev.next = curr.next;
                    else head = curr.next;

                    if (curr.next != null) curr.next.prev = curr.prev;
                    else tail = curr.prev;

                    return;
                }
                curr = curr.next;
            }
        }

        public void SearchByTitle(string title)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.title == title)
                {
                    Console.WriteLine($"Found Book: ID {temp.bookId}, Title: {temp.title}, Author: {temp.author}, Status: {(temp.isAvailable ? "Available" : "Checked Out")}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void SearchByAuthor(string author)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.author == author)
                {
                    Console.WriteLine($"Found Book: ID {temp.bookId}, Title: {temp.title}, Author: {temp.author}");
                }
                temp = temp.next;
            }
        }

        public void UpdateStatus(int id, bool status)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.bookId == id)
                {
                    temp.isAvailable = status;
                    Console.WriteLine($"Updated Status of Book ID {id} to {(status ? "Available" : "Checked Out")}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void CountBooks()
        {
            int count = 0;
            BookNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"Total Books in Library: {count}");
        }

        public void DisplayForward()
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.bookId}, Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Available: {temp.isAvailable}");
                temp = temp.next;
            }
        }

        public void DisplayReverse()
        {
            BookNode temp = tail;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.bookId}, Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Available: {temp.isAvailable}");
                temp = temp.prev;
            }
            Console.Write("End of Library Records");
        }
    }
}
