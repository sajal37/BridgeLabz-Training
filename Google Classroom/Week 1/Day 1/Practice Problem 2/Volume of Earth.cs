using System;
using System.Collections.Generic;
using System.Text;

namespace Google_Classroom.Practice_Problem_2
{
    internal class Volume_of_Earth
    {
        public void Demo()
        {
            double radiusKm = 6378.0;
            double pi = 3.14159;
            double radiusCubed = radiusKm * radiusKm * radiusKm;
            double volumeKm3 = (4.0 / 3.0) * pi * radiusCubed;
            double factor = 0.621371 * 0.621371 * 0.621371;
            double volumeMiles3 = volumeKm3 * factor;
            Console.WriteLine($"Volume (km^3): {volumeKm3}");
            Console.WriteLine($"Volume (mi^3): {volumeMiles3}");
        }
    }
}
