using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._02_Java_Constructors__Instance_vs._Class_Variables__Access_Modifiers_Level_1_Lab_Practice
{
    internal class Online_Course_Management
    {
        public static void Main(string[] args)
        {
            Course c1 = new Course("C# Basics", 3, 5000);
            Course c2 = new Course("Data Structures", 6, 8000);
            c1.Display();
            c2.Display();
            Course.UpdateInstituteName("BridgeLabz Solutions");
            c1.Display();
        }
    }
    public class Course
    {
        private string courseName;
        private int duration;
        private double fee;
        public static string instituteName = "BridgeLabz";
        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public void Display()
        {
            Console.WriteLine($"Course {courseName} is {duration} months long with fee {fee} at {instituteName}");
        }
        public static void UpdateInstituteName(string newName)
        {
            instituteName = newName;
            Console.WriteLine($"Institute name updated to {instituteName}");
        }
    }
}
