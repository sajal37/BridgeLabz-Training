using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_4._01___Submission_of_C__Generics
{
    internal class Multi_Level_University_Course_Management_System
    {
        public static void Main(string[] args)
        {
            ExamCourse mathExam = new ExamCourse("Final Exam", 4, 3, 60);
            Course<ExamCourse> mathCourse = new Course<ExamCourse>("Calculus II", "Mathematics", mathExam);
            mathCourse.DisplayCourseDetails();

            AssignmentCourse csAssignment = new AssignmentCourse("Programming Tasks", 3, 5, "Every Friday");
            Course<AssignmentCourse> csCourse = new Course<AssignmentCourse>("Data Structures", "Computer Science", csAssignment);
            csCourse.DisplayCourseDetails();

            ProjectCourse physicsProject = new ProjectCourse("Research Project", 4, "Quantum Mechanics", true);
            Course<ProjectCourse> physicsCourse = new Course<ProjectCourse>("Advanced Physics", "Physics", physicsProject);
            physicsCourse.DisplayCourseDetails();
        }
    }
    public abstract class CourseType
    {
        public string typeName;
        public int credits;

        public CourseType(string typeName, int credits)
        {
            this.typeName = typeName;
            this.credits = credits;
        }

        public abstract void DisplayEvaluationType();
    }

    public class ExamCourse : CourseType
    {
        public int numberOfExams;
        public int passingMarks;

        public ExamCourse(string typeName, int credits, int numberOfExams, int passingMarks) : base(typeName, credits)
        {
            this.numberOfExams = numberOfExams;
            this.passingMarks = passingMarks;
        }

        public override void DisplayEvaluationType()
        {
            Console.WriteLine($"Evaluation: Exam-Based, Exams: {numberOfExams}, Passing: {passingMarks}");
        }
    }

    public class AssignmentCourse : CourseType
    {
        public int numberOfAssignments;
        public string submissionDeadline;

        public AssignmentCourse(string typeName, int credits, int numberOfAssignments, string submissionDeadline) : base(typeName, credits)
        {
            this.numberOfAssignments = numberOfAssignments;
            this.submissionDeadline = submissionDeadline;
        }

        public override void DisplayEvaluationType()
        {
            Console.WriteLine($"Evaluation: Assignment-Based, Assignments: {numberOfAssignments}, Deadline: {submissionDeadline}");
        }
    }

    public class ProjectCourse : CourseType
    {
        public string projectTheme;
        public bool groupProject;

        public ProjectCourse(string typeName, int credits, string projectTheme, bool groupProject) : base(typeName, credits)
        {
            this.projectTheme = projectTheme;
            this.groupProject = groupProject;
        }

        public override void DisplayEvaluationType()
        {
            string projectType = groupProject ? "Group Project" : "Individual Project";
            Console.WriteLine($"Evaluation: Project-Based, Theme: {projectTheme}, Type: {projectType}");
        }
    }

    public class Course<T> where T : CourseType
    {
        public string courseName;
        public string department;
        public T evaluationType;

        public Course(string courseName, string department, T evaluationType)
        {
            this.courseName = courseName;
            this.department = department;
            this.evaluationType = evaluationType;
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine($"\nCourse: {courseName}, Department: {department}, Credits: {evaluationType.credits}");
            evaluationType.DisplayEvaluationType();
        }
    }
}
