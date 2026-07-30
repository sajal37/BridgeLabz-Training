using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_6._01_Java_Class_and_Object_Level_1_Lab_Practice
{
    internal class Handle_Book_Details
    {
        public static void Main(string[] args)
        {
            Book b1 = new Book("The Universe", "Stephen Hawking", 299);
            b1.Display();
        }
    }
    public class Book
    {
        private string title;
        private string author;
        private int price;
        public Book(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void Display()
        {
            Console.WriteLine($"The title of the book is {title} written by {author} and current price is {price}");
        }
    }
}
