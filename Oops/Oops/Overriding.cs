using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.Oops
{
    internal class Overriding
    {
        public static void Main(string[] args)
        {
            Animal a = new Dog();
            a.sound();
        }
    }
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
    class Dog:Animal
    {
        public override void sound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
