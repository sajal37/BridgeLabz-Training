using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public abstract class Bird
    {
        public int id;
        public Gender gender;
        public Bird(int id, Gender gender)
        {
            this.id = id;
            this.gender = gender;
        }
    }
    public interface IFlyable
    {

    }
    public interface ISwimmable
    {

    }
    public interface IRunnable
    {

    }
    public enum Gender
    {
        Male,
        Female
    }
}
