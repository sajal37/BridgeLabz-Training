using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeC_
{
    public class ThreadIntro
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(work1);
            t1.Start();
            t1.Join();
            Thread t2 = new Thread(work2);
            t2.Start();
            t2.Join();
            Thread t3 = new Thread(work3);
            t3.Start();
            t3.Join();
        }
        public static void work1()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("work 1");
            }
        }
        public static void work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("work 2");
            }
        }
        public static void work3()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("work 3");
            }
        }
    }
}
