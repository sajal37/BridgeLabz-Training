using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Week_2.Day_1.Sajal_Gupta___Submission_of_Inheritance
{
    internal class Animal_Hierarchy
    {
        public void Demo()
        {
            Animal dog = new Dog("Buddy", 3);
            Animal cat = new Cat("Whiskers", 2);
            Animal bird = new Bird("Tweety", 1);

            dog.MakeSound();
            cat.MakeSound();
            bird.MakeSound();
        }
    }

    class Animal
    {
        protected string Name;
        protected int Age;

        public Animal (string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public Dog (string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Dog barks");
        }
    }

    class Cat : Animal
    {
        public Cat (string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Cat meows");
        }
    }

    class Bird : Animal
    {
        public Bird (string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the Bird chirps");
        }
    }
}
