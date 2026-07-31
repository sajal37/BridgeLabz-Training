using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Book_Library_System
    {
        public static void Main(string[] args)
        {
            EBook eb1 = new EBook("978-0-13-468599-1", "Clean Code", "Robert C. Martin", "PDF");
            eb1.Display();
            eb1.SetAuthor("R. C. Martin");
            Console.WriteLine($"Updated author is {eb1.GetAuthor()}");
        }
    }
    public class Book
    {
        public string isbn;
        protected string title;
        private string author;
        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }
        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }
    public class EBook : Book
    {
        private string format;
        public EBook (string isbn, string title, string author, string format) : base(isbn, title, author)
        {
            this.format = format;
        }
        public void Display()
        {
            Console.WriteLine($"The book {title} with ISBN {isbn} is written by {GetAuthor()} in {format} format");
        }
    }
}
