using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Educational_Course_Hierarchy
    {
        public void Demo()
        {
            Course c1 = new Course("Mathematics", 40);
            OnlineCourse c2 = new OnlineCourse("Data Science", 60, "Coursera", true);
            PaidOnlineCourse c3 = new PaidOnlineCourse("Machine Learning", 80, "Udemy", true, 199.99, 20.0);

            c1.DisplayCourseInfo();
            c2.DisplayCourseInfo();
            c3.DisplayCourseInfo();
        }
    }

    class Course
    {
        protected string CourseName;
        protected int Duration;

        public Course (string name, int duration)
        {
            this.CourseName = name;
            this.Duration = duration;
        }

        public virtual void DisplayCourseInfo()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} hours");
        }
    }

    class OnlineCourse : Course
    {
        protected string Platform;
        protected bool IsRecorded;

        public OnlineCourse (string name, int duration, string platform, bool recorded) : base(name, duration)
        {
            this.Platform = platform;
            this.IsRecorded = recorded;
        }

        public override void DisplayCourseInfo()
        {
            string recordedStatus = IsRecorded ? "Recorded" : "Live";
            Console.WriteLine($"Online Course: {CourseName}, Duration: {Duration} hours, Platform: {Platform}, Type: {recordedStatus}");
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        private double Fee;
        private double Discount;

        public PaidOnlineCourse (string name, int duration, string platform, bool recorded, double fee, double discount) : base(name, duration, platform, recorded)
        {
            this.Fee = fee;
            this.Discount = discount;
        }

        public override void DisplayCourseInfo()
        {
            string recordedStatus = IsRecorded ? "Recorded" : "Live";
            double finalPrice = Fee - (Fee * Discount / 100);
            Console.WriteLine($"Paid Online Course: {CourseName}, Duration: {Duration} hours, Platform: {Platform}, Type: {recordedStatus}");
            Console.WriteLine($"Original Fee: ${Fee}, Discount: {Discount}%, Final Price: ${finalPrice}");
        }
    }
}
