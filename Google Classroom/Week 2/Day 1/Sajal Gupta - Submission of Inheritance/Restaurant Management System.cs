using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance_Restaurant
{
    internal class Restaurant_Management_System
    {
        public void Demo()
        {
            Chef chef = new Chef("Gordon Ramsay", 101);
            Waiter waiter = new Waiter("Michael Brown", 102);

            chef.PerformDuties();
            waiter.PerformDuties();
        }
    }

    interface Worker
    {
        void PerformDuties();
    }

    class Person
    {
        protected string Name;
        protected int Id;

        public Person (string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }

    class Chef : Person, Worker
    {
        public Chef (string name, int id) : base(name, id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine($"Chef {Name} (ID: {Id}) is preparing delicious meals");
        }
    }

    class Waiter : Person, Worker
    {
        public Waiter (string name, int id) : base(name, id)
        {
        }

        public void PerformDuties()
        {
            Console.WriteLine($"Waiter {Name} (ID: {Id}) is serving customers");
        }
    }
}
