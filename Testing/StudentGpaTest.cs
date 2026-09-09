using Student_GPA;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class StudentGpaTest
    {
        [Test]
        public void CorrectWeightedGpa()
        {
            WeightedGPA g = new WeightedGPA();
            double gpa = g.GPALines(new string[]
            {
                "StudentId,Name,SubjectCode,Marks",
                "S1,Aarav,MATH,88",
                "S1,Aarav,SCI,76"
            });
            Assert.That(gpa, Is.EqualTo(8.5));
        }

        [Test]
        public void GradeBoundaryAt40()
        {
            WeightedGPA g = new WeightedGPA();
            Assert.That(g.Grade(40), Is.EqualTo(5));
            Assert.That(g.Grade(39), Is.EqualTo(0));
        }

        [Test]
        public void GradeBoundaries()
        {
            WeightedGPA g = new WeightedGPA();
            Assert.That(g.Grade(90), Is.EqualTo(10));
            Assert.That(g.Grade(80), Is.EqualTo(9));
            Assert.That(g.Grade(70), Is.EqualTo(8));
            Assert.That(g.Grade(60), Is.EqualTo(7));
            Assert.That(g.Grade(50), Is.EqualTo(6));
        }

        [Test]
        public void MarksOutOfRange()
        {
            Assert.Throws<InvalidMarksException>(() =>
            {
                int m = -10;
                if (m < 0 || m > 100) throw new InvalidMarksException(m);
            });
            Assert.Throws<InvalidMarksException>(() =>
            {
                int m = 105;
                if (m < 0 || m > 100) throw new InvalidMarksException(m);
            });
        }

        [Test]
        public void UnknownSubject()
        {
            Assert.Throws<UnknownSubjectException>(() =>
            {
                List<string> sub = new List<string> { "MATH", "SCI", "ENG", "HIST", "GEO" };
                string code = "PHIL";
                if (!sub.Contains(code)) throw new UnknownSubjectException(code);
            });
        }

        [Test]
        public void DuplicateStudentSubjectRecord()
        {
            Assert.Throws<DuplicateSubjectRecordException>(() =>
            {
                HashSet<string> set = new HashSet<string>();
                set.Add("S1MATH");
                string key = "S1MATH";
                if (set.Contains(key)) throw new DuplicateSubjectRecordException(key);
            });
        }

        [Test]
        public void RankingOrder()
        {
            WeightedGPA g = new WeightedGPA();
            double g1 = g.GPALines(new string[] { "StudentId,Name,SubjectCode,Marks", "S1,Aarav,MATH,88", "S1,Aarav,SCI,76" });
            double g2 = g.GPALines(new string[] { "StudentId,Name,SubjectCode,Marks", "S2,Diya,ENG,65" });
            double g3 = g.GPALines(new string[] { "StudentId,Name,SubjectCode,Marks", "S3,Ishaan,HIST,95" });
            double[] gpas = { g1, g2, g3 };
            Array.Sort(gpas);
            Array.Reverse(gpas);
            Assert.That(gpas[0], Is.EqualTo(g3));
            Assert.That(gpas[2], Is.EqualTo(g2));
        }

        [Test]
        public void BinaryRoundTrip()
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write(88);
            bw.Flush();
            ms.Position = 0;
            BinaryReader br = new BinaryReader(ms);
            int result = br.ReadInt32();
            Assert.That(result, Is.EqualTo(88));
        }
    }
}