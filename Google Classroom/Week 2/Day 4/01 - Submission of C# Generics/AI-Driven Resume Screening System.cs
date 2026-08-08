using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_4._01___Submission_of_C__Generics
{
    internal class AI_Driven_Resume_Screening_System
    {
        public static void Main(string[] args)
        {
            List<string> languages = new List<string> { "C#", "Python", "Java" };
            SoftwareEngineer seRole = new SoftwareEngineer("Senior Software Engineer", "Engineering", 5, languages, true);
            Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("John Smith", "john@email.com", 6, seRole);
            ProcessResume(resume1);

            List<string> tools = new List<string> { "Python", "R", "TensorFlow", "SQL" };
            DataScientist dsRole = new DataScientist("Data Scientist", "Analytics", 3, tools, true);
            Resume<DataScientist> resume2 = new Resume<DataScientist>("Sarah Johnson", "sarah@email.com", 2, dsRole);
            ProcessResume(resume2);

            ProductManager pmRole = new ProductManager("Product Manager", "Product", 4, true, 8);
            Resume<ProductManager> resume3 = new Resume<ProductManager>("Mike Chen", "mike@email.com", 5, pmRole);
            ProcessResume(resume3);
        }

        static void ProcessResume<T>(Resume<T> resume) where T : JobRole
        {
            Console.WriteLine($"\nCandidate: {resume.candidateName}, Email: {resume.email}, Experience: {resume.yearsExperience} years");
            resume.appliedRole.DisplayRequirements();
            
            if(resume.ScreenResume())
            {
                Console.WriteLine("Status: QUALIFIED");
            }
            else
            {
                int needed = resume.appliedRole.experienceRequired - resume.yearsExperience;
                Console.WriteLine($"Status: NOT QUALIFIED (needs {needed} more years)");
            }
        }
    }
    public abstract class JobRole
    {
        public string roleName;
        public string department;
        public int experienceRequired;

        public JobRole(string roleName, string department, int experienceRequired)
        {
            this.roleName = roleName;
            this.department = department;
            this.experienceRequired = experienceRequired;
        }

        public abstract void DisplayRequirements();
    }

    public class SoftwareEngineer : JobRole
    {
        public List<string> programmingLanguages;
        public bool requiresDegree;

        public SoftwareEngineer(string roleName, string department, int experienceRequired, List<string> programmingLanguages, bool requiresDegree) : base(roleName, department, experienceRequired)
        {
            this.programmingLanguages = programmingLanguages;
            this.requiresDegree = requiresDegree;
        }

        public override void DisplayRequirements()
        {
            Console.Write($"Role: {roleName}, Department: {department}, Experience: {experienceRequired} years, Languages: ");
            foreach(string lang in programmingLanguages)
            {
                Console.Write($"{lang} ");
            }
            string degree = requiresDegree ? "Degree Required" : "Degree Optional";
            Console.WriteLine($", {degree}");
        }
    }

    public class DataScientist : JobRole
    {
        public List<string> toolsRequired;
        public bool requiresMaster;

        public DataScientist(string roleName, string department, int experienceRequired, List<string> toolsRequired, bool requiresMaster) : base(roleName, department, experienceRequired)
        {
            this.toolsRequired = toolsRequired;
            this.requiresMaster = requiresMaster;
        }

        public override void DisplayRequirements()
        {
            Console.Write($"Role: {roleName}, Department: {department}, Experience: {experienceRequired} years, Tools: ");
            foreach(string tool in toolsRequired)
            {
                Console.Write($"{tool} ");
            }
            string master = requiresMaster ? "Master's Required" : "Bachelor's Sufficient";
            Console.WriteLine($", {master}");
        }
    }

    public class ProductManager : JobRole
    {
        public bool requiresLeadership;
        public int teamSizeManaged;

        public ProductManager(string roleName, string department, int experienceRequired, bool requiresLeadership, int teamSizeManaged) : base(roleName, department, experienceRequired)
        {
            this.requiresLeadership = requiresLeadership;
            this.teamSizeManaged = teamSizeManaged;
        }

        public override void DisplayRequirements()
        {
            string leadership = requiresLeadership ? "Leadership Required" : "No Leadership Required";
            Console.WriteLine($"Role: {roleName}, Department: {department}, Experience: {experienceRequired} years, {leadership}, Team Size: {teamSizeManaged}");
        }
    }

    public class Resume<T> where T : JobRole
    {
        public string candidateName;
        public string email;
        public int yearsExperience;
        public T appliedRole;

        public Resume(string candidateName, string email, int yearsExperience, T appliedRole)
        {
            this.candidateName = candidateName;
            this.email = email;
            this.yearsExperience = yearsExperience;
            this.appliedRole = appliedRole;
        }

        public bool ScreenResume()
        {
            return yearsExperience >= appliedRole.experienceRequired;
        }
    }
}
