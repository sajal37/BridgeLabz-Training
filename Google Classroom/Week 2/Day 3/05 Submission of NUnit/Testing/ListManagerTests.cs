using System;
using System.Collections.Generic;
using NUnit.Framework;
using Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Actual_Work;

namespace Google_Classroom.Week_2.Day_3._05_Submission_of_NUnit.Testing
{
    [TestFixture]
    public class ListManagerTests
    {
        private ListManager Manager;
        private List<int> TestList;

        [SetUp]
        public void Setup()
        {
            Manager = new ListManager();
            TestList = new List<int>();
        }

        [Test]
        public void AddElement_AddsSingleElement_IncreasesList()
        {
            Manager.AddElement(TestList, 5);
            int Count = TestList.Count;
            Assert.That(Count, Is.EqualTo(1));
            Assert.That(TestList, Does.Contain(5));
        }

        [Test]
        public void RemoveElement_RemovesExistingElement_DecreasesList()
        {
            TestList.Add(10);
            TestList.Add(20);
            Manager.RemoveElement(TestList, 10);
            int Count = TestList.Count;
            Assert.That(Count, Is.EqualTo(1));
            Assert.That(TestList, Does.Not.Contain(10));
        }

        [Test]
        public void GetSize_EmptyList_ReturnsZero()
        {
            int Size = Manager.GetSize(TestList);
            Assert.That(Size, Is.EqualTo(0));
        }

        [Test]
        public void GetSize_ListWithElements_ReturnsCorrectSize()
        {
            TestList.Add(1);
            TestList.Add(2);
            TestList.Add(3);
            int Size = Manager.GetSize(TestList);
            Assert.That(Size, Is.EqualTo(3));
        }
    }
}
