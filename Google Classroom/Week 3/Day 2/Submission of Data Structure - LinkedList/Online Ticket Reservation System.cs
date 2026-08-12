using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_3.Day_2.Submission_of_Data_Structure___LinkedList
{
    internal class Online_Ticket_Reservation_System
    {
        public static void Main(string[] args)
        {
            CircularTicketSystem system1 = new CircularTicketSystem();

            system1.AddReservation(1001, "Sajal Gupta", "Avatar 2", "A-12", "14:30");
            system1.AddReservation(1002, "Rahul Verma", "Avatar 2", "A-13", "14:35");
            system1.AddReservation(1003, "Priya Sharma", "Inception", "B-05", "15:00");

            Console.WriteLine("All Ticket Reservations:");
            system1.DisplayTickets();

            Console.WriteLine("\nTotal Booked Tickets:");
            system1.CalculateTotalTickets();

            Console.WriteLine("\nSearching for Tickets of Movie 'Avatar 2':");
            system1.SearchByMovie("Avatar 2");

            Console.WriteLine("\nRemoving Ticket ID 1002:");
            system1.RemoveReservation(1002);

            Console.WriteLine("\nRemaining Tickets:");
            system1.DisplayTickets();
        }
    }

    class TicketNode
    {
        public int ticketId;
        public string custName;
        public string movieName;
        public string seatNo;
        public string bookingTime;
        public TicketNode next;

        public TicketNode (int ticketId, string custName, string movieName, string seatNo, string bookingTime)
        {
            this.ticketId = ticketId;
            this.custName = custName;
            this.movieName = movieName;
            this.seatNo = seatNo;
            this.bookingTime = bookingTime;
            this.next = null;
        }
    }

    class CircularTicketSystem
    {
        private TicketNode head;
        private TicketNode tail;

        public void AddReservation(int id, string cust, string movie, string seat, string time)
        {
            TicketNode newNode = new TicketNode(id, cust, movie, seat, time);
            if (head == null)
            {
                head = tail = newNode;
                newNode.next = head;
                return;
            }
            tail.next = newNode;
            tail = newNode;
            tail.next = head;
        }

        public void RemoveReservation(int id)
        {
            if (head == null) return;

            TicketNode currNode = head;
            TicketNode prevNode = tail;

            do
            {
                if (currNode.ticketId == id)
                {
                    if (currNode == head && currNode == tail)
                    {
                        head = tail = null;
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
                    return;
                }
                prevNode = currNode;
                currNode = currNode.next;
            } while (currNode != head);
        }

        public void SearchByCustomer(string cust)
        {
            if (head == null) return;
            TicketNode temp = head;
            do
            {
                if (temp.custName == cust)
                {
                    Console.WriteLine($"Found Ticket ID {temp.ticketId} for Customer {temp.custName}, Movie: {temp.movieName}, Seat: {temp.seatNo}");
                }
                temp = temp.next;
            } while (temp != head);
        }

        public void SearchByMovie(string movie)
        {
            if (head == null) return;
            TicketNode temp = head;
            do
            {
                if (temp.movieName == movie)
                {
                    Console.WriteLine($"Found Ticket ID {temp.ticketId} for Movie {temp.movieName}, Customer: {temp.custName}, Seat: {temp.seatNo}");
                }
                temp = temp.next;
            } while (temp != head);
        }

        public void CalculateTotalTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Booked Tickets: 0");
                return;
            }
            int count = 0;
            TicketNode temp = head;
            do
            {
                count++;
                temp = temp.next;
            } while (temp != head);
            Console.WriteLine($"Total Booked Tickets: {count}");
        }

        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets reserved.");
                return;
            }
            TicketNode temp = head;
            do
            {
                Console.WriteLine($"Ticket ID: {temp.ticketId}, Customer: {temp.custName}, Movie: {temp.movieName}, Seat: {temp.seatNo}, Time: {temp.bookingTime}");
                temp = temp.next;
            } while (temp != head);
            Console.Write("End of Reservations");
        }
    }
}
