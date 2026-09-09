using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Student_GPA
{
    public class StudentException : Exception
    {
        public StudentException()
        {
        }
    }
    public class InvalidMarksException: StudentException
    {
        public int marks;
        public InvalidMarksException(int marks)
        {
            this.marks = marks;
        }
    }
    public class UnknownSubjectException: StudentException
    {
        public string subject;
        public UnknownSubjectException(string subject)
        {
            this.subject = subject;
        }
    }
    public class DuplicateSubjectRecordException: StudentException
    {
        public string subject;
        public DuplicateSubjectRecordException(string subject)
        {
            this.subject = subject;
        }
    }
}