using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Bird_Sanctuary
{
    public class Ostrich : Bird, IRunnable
    {
        public Ostrich(int id, Gender gender) : base(id, gender)
        {

        }
    }
    public class Duck : Bird, IFlyable, ISwimmable, IRunnable
    {
        public Duck(int id, Gender gender) : base(id, gender)
        {

        }
    }
    public class Eagle : Bird, IFlyable
    {
        public Eagle(int id, Gender gender) : base(id, gender)
        {

        }
    }
    public class Parrot : Bird, IFlyable
    {
        public Parrot(int id, Gender gender) : base(id, gender)
        {

        }
    }
    public class Penguin : Bird, IRunnable, ISwimmable
    {
        public Penguin(int id, Gender gender) : base(id, gender)
        {

        }
    }
}
