using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Bird_Sanctuary
{
    public class BirdObjects
    {
        public static void Main(string[] args)
        {
            BirdManagement sanc = new BirdManagement();
            Bird os1 = new Ostrich(1, Gender.Male);
            Bird d1 = new Duck(2, Gender.Female);
            Bird e1 = new Eagle(3, Gender.Male);
            Bird par1 = new Parrot(4, Gender.Male);
            Bird pen1 = new Penguin(5, Gender.Female);
            sanc.Add(os1);
            sanc.Add(d1);
            sanc.Add(e1);
            sanc.Add(par1);
            sanc.Add(pen1);
            sanc.Display();
        }
    }
}
