using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_1.Day_3._04_C__Methods_Level_3_Practice_Programs
{
    internal class Generate_Unique_OTP
    {
        public static int GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 1000000);
        }
        public static bool AreOTPsUnique(int[] otps)
        {
            for (int i = 0; i < otps.Length; i++)
            {
                for (int j = i + 1; j < otps.Length; j++)
                {
                    if (otps[i] == otps[j])
                        return false;
                }
            }
            return true;
        }
        public void Demo()
        {
            int[] otps = new int[10];
            for (int i = 0; i < 10; i++)
            {
                otps[i] = GenerateOTP();
                Console.WriteLine($"OTP {i + 1}: {otps[i]}");
            }
            bool isUnique = AreOTPsUnique(otps);
            Console.Write($"All unique: {isUnique}");
        }
    }
}
