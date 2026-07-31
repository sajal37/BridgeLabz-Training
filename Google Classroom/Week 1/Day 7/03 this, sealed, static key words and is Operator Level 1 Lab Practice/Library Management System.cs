using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Library_Management_System
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("Clean Code", "Robert C. Martin", "978-0-13-235088-4");
            Book b2 = new Book("The Pragmatic Programmer", "Andy Hunt", "978-0-20-161622-4");
            Book.DisplayLibraryName();
            DisplayBookInfo(b1);
            DisplayBookInfo(b2);
        }
        public static void DisplayBookInfo(object obj)
        {
            if (obj is Book b)
            {
                b.Display();
            }
        }
    }
    class Book
    {
        public static string libraryName = "City Central Library";
        private string title;
        private string author;
        public readonly string isbn;
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }
        public void Display()
        {
            Console.WriteLine($"The book {title} by {author} has ISBN {isbn}");
        }
        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library name is {libraryName}");
        }
    }
}
