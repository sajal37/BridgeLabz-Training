using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_3
{
    internal class Sample_Program_2_Input
    {
        public void Demo()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter from city: ");
            string fromCity = Console.ReadLine();
            Console.Write("Enter via city: ");
            string viaCity = Console.ReadLine();
            Console.Write("Enter to city: ");
            string toCity = Console.ReadLine();
            Console.Write("Enter fromToVia (miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter viaToFinalCity (miles): ");
            double viaToFinal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter time taken (hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Trip: {name}, {fromCity}->{viaCity}->{toCity}, Dist: {fromToVia + viaToFinal}, Time: {timeTaken}");
        }
    }
}
