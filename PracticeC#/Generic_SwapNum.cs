using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeC_
{
    internal class Generic_SwapNum
    {
        public static void Main(string[] args)
        {
            int a = 4;
            int b = 7;
            Swap(ref a, ref b);
            string c = "sajal";
            string d = "gupta";
            Swap(ref c, ref d);
            double e = 4.77;
            double f = 5.03;
            Swap(ref e, ref f);
            char g = 'o';
            char h = 't';
            Swap(ref g, ref h);

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
