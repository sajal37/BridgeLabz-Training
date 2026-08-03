using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Library_Management_with_Books_and_Authors
    {
        public void Demo()
        {
            Author author = new Author("The Great Gatsby", 1925, "F. Scott Fitzgerald", "American novelist and short story writer");
            author.DisplayInfo();
        }
    }

    class Book
    {
        protected string Title;
        protected int PublicationYear;

        public Book (string title, int year)
        {
            this.Title = title;
            this.PublicationYear = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}, Published: {PublicationYear}");
        }
    }

    class Author : Book
    {
        private string Name;
        private string Bio;

        public Author (string title, int year, string name, string bio) : base(title, year)
        {
            this.Name = name;
            this.Bio = bio;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
            Console.WriteLine($"Author: {Name}");
            Console.WriteLine($"Bio: {Bio}");
        }
    }
}
