using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary
{
    public class BirdManagement
    {
        public List<Bird> list = new List<Bird>();
        public void Add(Bird bird)
        {
            list.Add(bird);
        }
        public void Remove(Bird bird)
        {
            if (list.Contains(bird)) list.Remove(bird);
            return;
        }
        public void Display()
        {
            foreach (Bird bird in list)
            {
                Console.WriteLine($"{bird.id} {bird.gender}");
            }
        }
    }
}
