using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Google_Classroom.Week_4.Day_1._03_Submission_of_C__Streams
{
    internal class ByteArray_Stream___Convert_Image_to_ByteArray
    {
        public static void Main(string[] args)
        {
            string srcImage = "input_image.png";
            string destImage = "output_image.png";
            if (!File.Exists(srcImage))
            {
                byte[] dummy = new byte[] { 137, 80, 78, 71, 13, 10, 26, 10, 0, 0, 0, 13, 73, 72, 68, 82 };
                File.WriteAllBytes(srcImage, dummy);
            }
            try
            {
                byte[] imageBytes = File.ReadAllBytes(srcImage);
                byte[] memoryBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    memoryBytes = ms.ToArray();
                }
                using (FileStream fs = new FileStream(destImage, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(memoryBytes, 0, memoryBytes.Length);
                }
                bool isSame = true;
                byte[] b1 = File.ReadAllBytes(srcImage);
                byte[] b2 = File.ReadAllBytes(destImage);
                if (b1.Length != b2.Length) isSame = false;
                else
                {
                    for (int i = 0; i < b1.Length; i++)
                    {
                        if (b1[i] != b2[i])
                        {
                            isSame = false;
                            break;
                        }
                    }
                }
                Console.Write($"Identical: {isSame}");
            }
            catch (IOException ex)
            {
                Console.Write($"IO Error: {ex.Message}");
            }
        }
    }
}
