using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Library_Management_System
    {
        public void Demo()
        {
            LibraryItem[] items = new LibraryItem[3];
            items[0] = new Book(101, "The Alchemist", "Paulo Coelho");
            items[1] = new Magazine(102, "Forbes", "Forbes Media");
            items[2] = new DVD(103, "Inception", "Christopher Nolan");

            for (int i = 0; i < items.Length; i++)
            {
                items[i].GetItemDetails();
                Console.WriteLine($"Loan Duration: {items[i].GetLoanDuration()} days");
                if (items[i] is IReservable)
                {
                    IReservable reservable = (IReservable)items[i];
                    reservable.ReserveItem();
                }
                Console.WriteLine();
            }
        }
    }

    interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    abstract class LibraryItem
    {
        private int itemId;
        private string title;
        protected string author;

        public LibraryItem (int id, string title, string author)
        {
            this.itemId = id;
            this.title = title;
            this.author = author;
        }

        public int ItemId
        {
            get { return itemId; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}, Title: {title}, Author: {author}");
        }
    }

    class Book : LibraryItem, IReservable
    {
        public Book (int id, string title, string author) : base(id, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 14;
        }

        public void ReserveItem()
        {
            Console.WriteLine($"Book {Title} reserved");
        }

        public bool CheckAvailability()
        {
            return true;
        }
    }

    class Magazine : LibraryItem
    {
        public Magazine (int id, string title, string publisher) : base(id, title, publisher)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }
    }

    class DVD : LibraryItem, IReservable
    {
        public DVD (int id, string title, string director) : base(id, title, director)
        {
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            Console.WriteLine($"DVD {Title} reserved");
        }

        public bool CheckAvailability()
        {
            return true;
        }
    }
}
