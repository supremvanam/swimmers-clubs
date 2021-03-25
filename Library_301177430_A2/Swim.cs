using System;
namespace Library_301177430_A2
{
    public class Swim
    {
        public ushort Heat { get; set; }
        public byte Lane { get; set; }
        public DateTime Time { get; set; }

        public Swim()
        {

        }

        public Swim(ushort heat, byte lane)
        {
            Heat = heat;
            Lane = lane;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
