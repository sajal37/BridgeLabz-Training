using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_2._06_Submission_of_Encapsulation__Polymorphism__Interface_and_Abstract_Class
{
    internal class Hospital_Patient_Management
    {
        public void Demo()
        {
            Patient[] patients = new Patient[2];
            patients[0] = new InPatient(101, "Suresh Kumar", 65, 5);
            patients[1] = new OutPatient(102, "Meena Patel", 45);

            for (int i = 0; i < patients.Length; i++)
            {
                patients[i].GetPatientDetails();
                Console.WriteLine($"Bill Amount: {patients[i].CalculateBill()}");
                Console.WriteLine();
            }
        }
    }

    interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    abstract class Patient : IMedicalRecord
    {
        private int patientId;
        private string name;
        protected int age;
        private string diagnosis;

        public Patient (int id, string name, int age)
        {
            this.patientId = id;
            this.name = name;
            this.age = age;
        }

        public int PatientId
        {
            get { return patientId; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            { 
                if (value > 0)
                    age = value; 
            }
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientId}, Name: {name}, Age: {age}");
        }

        public void AddRecord(string record)
        {
            diagnosis = record;
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Diagnosis: {diagnosis}");
        }
    }

    class InPatient : Patient
    {
        private int daysAdmitted;

        public InPatient (int id, string name, int age, int days) : base(id, name, age)
        {
            this.daysAdmitted = days;
        }

        public override double CalculateBill()
        {
            return daysAdmitted * 2000;
        }
    }

    class OutPatient : Patient
    {
        public OutPatient (int id, string name, int age) : base(id, name, age)
        {
        }

        public override double CalculateBill()
        {
            return 500;
        }
    }
}
