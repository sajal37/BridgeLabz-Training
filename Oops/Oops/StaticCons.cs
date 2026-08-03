using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.Oops
{
    internal class StaticCons
    {
        public static void Main(string[] args)
        {
            //Student s = new Student();

            //Student.Hello();
            //Student s = new Student();

            //Student s1 = new Student();
            //Student s2 = new Student();

            Student.Hello();
        }
    }
    class Student
    {
        static Student()
        {
            Console.WriteLine("static constructor");
        }
        public Student()
        {
            Console.WriteLine("normal constructor");
        }
        public static void Hello()
        {
            Console.WriteLine("hello");
        }
    }
}
