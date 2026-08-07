using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class UserRegistration
    {
        public bool RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrEmpty(username))
                throw new ArgumentException("Username cannot be empty");

            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                throw new ArgumentException("Invalid email address");

            if (string.IsNullOrEmpty(password) || password.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters");

            return true;
        }
    }
}
