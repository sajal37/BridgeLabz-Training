using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Google_Classroom.Week_1.Day_7._03_this__sealed__static_key_words_and_is_Operator_Level_1_Lab_Practice
{
    internal class Hospital_Management_System
    {
        public static void Main(string[] args)
        {
            Patient p1 = new Patient("Raj Malhotra", 45, "Fever", "P101");
            Patient p2 = new Patient("Sunita Devi", 60, "Diabetes", "P102");
            Patient.GetTotalPatients();
            DisplayPatientInfo(p1);
            DisplayPatientInfo(p2);
        }
        public static void DisplayPatientInfo(object obj)
        {
            if (obj is Patient p)
            {
                p.Display();
            }
        }
    }
    public class Patient
    {
        public static string hospitalName = "City Hospital";
        public static int totalPatients;
        private string name;
        private int age;
        private string ailment;
        public readonly string patientID;
        public Patient (string name, int age, string ailment, string patientID)
        {
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            this.patientID = patientID;
            totalPatients++;
        }
        public void Display()
        {
            Console.WriteLine($"Patient {name} age {age} admitted at {hospitalName} with ID {patientID} for {ailment}");
        }
        public static void GetTotalPatients()
        {
            Console.WriteLine($"Total patients admitted are {totalPatients}");
        }
    }
}
