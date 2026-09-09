using System;
using System.Collections.Generic;
using System.Text;

namespace Student_GPA
{
    public class BinaryTrip
    {
        public void Binary()
        {
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            bw.Write("S1");
            bw.Write("Aarav");
            bw.Write("MATH");
            bw.Write(88);
            bw.Flush();
            ms.Position = 0;
            BinaryReader br = new BinaryReader(ms);
            string id = br.ReadString();
            string name = br.ReadString();
            string code = br.ReadString();
            int marks = br.ReadInt32();
        }
    }
}
