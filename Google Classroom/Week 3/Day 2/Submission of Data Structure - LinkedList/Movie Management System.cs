using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Movie_Management_System
    {
        public static void Main(string[] args)
        {
            MovieDoublyList list1 = new MovieDoublyList();

            list1.AddAtEnd("Inception", "Christopher Nolan", 2010, 8.8);
            list1.AddAtBeginning("Interstellar", "Christopher Nolan", 2014, 8.6);
            list1.AddAtEnd("The Dark Knight", "Christopher Nolan", 2008, 9.0);

            Console.WriteLine("Movies Display Forward:");
            list1.DisplayForward();

            Console.WriteLine("\nMovies Display Reverse:");
            list1.DisplayReverse();

            Console.WriteLine("\nSearching for Movies by Director 'Christopher Nolan':");
            list1.SearchByDirector("Christopher Nolan");

            Console.WriteLine("\nUpdating Rating of 'Inception' to 9.0:");
            list1.UpdateRating("Inception", 9.0);

            Console.WriteLine("\nRemoving Movie 'Interstellar':");
            list1.RemoveByTitle("Interstellar");

            Console.WriteLine("\nMovies Forward After Removal:");
            list1.DisplayForward();
        }
    }

    class MovieNode
    {
        public string title;
        public string director;
        public int year;
        public double rating;
        public MovieNode prev;
        public MovieNode next;

        public MovieNode (string title, string director, int year, double rating)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
            this.prev = null;
            this.next = null;
        }
    }

    class MovieDoublyList
    {
        private MovieNode head;
        private MovieNode tail;

        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }

        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (tail == null)
            {
                head = tail = newNode;
                return;
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }

        public void RemoveByTitle(string title)
        {
            MovieNode curr = head;
            while (curr != null)
            {
                if (curr.title == title)
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

        public void SearchByDirector(string director)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.director == director)
                {
                    Console.WriteLine($"Found Movie: {temp.title} ({temp.year}) Directed by {temp.director}, Rating: {temp.rating}");
                }
                temp = temp.next;
            }
        }

        public void SearchByRating(double rating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.rating >= rating)
                {
                    Console.WriteLine($"Movie with Rating >= {rating}: {temp.title}, Rating: {temp.rating}");
                }
                temp = temp.next;
            }
        }

        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.title == title)
                {
                    temp.rating = newRating;
                    Console.WriteLine($"Updated rating for {title} to {newRating}");
                    return;
                }
                temp = temp.next;
            }
        }

        public void DisplayForward()
        {
            MovieNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Year: {temp.year}, Rating: {temp.rating}");
                temp = temp.next;
            }
        }

        public void DisplayReverse()
        {
            MovieNode temp = tail;
            while (temp != null)
            {
                Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Year: {temp.year}, Rating: {temp.rating}");
                temp = temp.prev;
            }
            Console.Write("End of List");
        }
    }
}
