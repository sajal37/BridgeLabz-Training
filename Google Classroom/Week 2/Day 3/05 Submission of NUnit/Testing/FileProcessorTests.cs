using System;
using System.IO;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class FileProcessorTests
    {
        private FileProcessor Processor;
        private string TestFile;

        [SetUp]
        public void Setup()
        {
            Processor = new FileProcessor();
            TestFile = "test.txt";
        }

        [TearDown]
        public void TearDown()
        {
            if (File.Exists(TestFile))
                File.Delete(TestFile);
        }

        [Test]
        public void WriteToFile_CreatesFile_FileExists()
        {
            Processor.WriteToFile(TestFile, "Hello World");
            bool Exists = Processor.FileExists(TestFile);
            Assert.That(Exists, Is.True);
        }

        [Test]
        public void ReadFromFile_ReadsContent_ReturnsCorrectText()
        {
            string Content = "Test Content";
            Processor.WriteToFile(TestFile, Content);
            string Result = Processor.ReadFromFile(TestFile);
            Assert.That(Result, Is.EqualTo(Content));
        }

        [Test]
        public void ReadFromFile_FileNotExists_ThrowsIOException()
        {
            Assert.That(() => Processor.ReadFromFile("nonexistent.txt"), Throws.TypeOf<IOException>());
        }
    }
}
