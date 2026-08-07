using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if (password == null || password.Length < 8)
                return false;

            bool HasUpper = false;
            bool HasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    HasUpper = true;
                if (char.IsDigit(password[i]))
                    HasDigit = true;
            }

            bool Valid = HasUpper && HasDigit;
            return Valid;
        }
    }
}
