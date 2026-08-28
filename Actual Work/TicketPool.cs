using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Actual_Work
{
    public class TicketPool<T>
    {
        Stack<string> st1 = new Stack<string>();
        Stack<string> st2 = new Stack<string>();
        Stack<int> st3 = new Stack<int>();
        Stack<string> st4 = new Stack<string>();
        public void add(string code, string name, int num, string status)
        {
                st1.Push(code);
                st2.Push(name);
                st3.Push(num);
                st4.Push(status);
        }
        public void remove()
        {
            //int num1 = st1.Count();
            st1.Pop();
            st2.Pop();
            st3.Pop();
            st4.Pop();
        }
        public bool validate(string code, string name, int num, string status)
        {
            string pattern = @"^TKT-[A-F0-9]{8}$";
            if (Regex.IsMatch(code, pattern))
            {
                add(code, name, num, status);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int numberOfTickets()
        {
            return st1.Count();
        }
        public void book()
        {
            validate("TKT-AFFB0553", "Concert", 23, "sold");
        }
        public void display()
        {
            Console.WriteLine(st1.Peek());
            Console.WriteLine(st2.Peek());
            Console.WriteLine(st3.Peek());
            Console.WriteLine(st4.Peek());
        }
    }
}
