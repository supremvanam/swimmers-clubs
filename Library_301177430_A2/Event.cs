using System;
using System.Collections.Generic;
namespace Library_301177430_A2
{
    public class Event
    {

        private RegistrantsSwims swimmingEvents;

        public EventDistance Distance { get; set; }
        public Stroke Stroke { get; set; }
        public List<Registrant> Swimmers { get; }


        public Event()
        {
            swimmingEvents = new RegistrantsSwims();
        }

        public Event(EventDistance distance, Stroke stroke) : this()
        {
            Distance = distance;
            Stroke = stroke;
        }

        public void AddSwimmer(Registrant aSwimmer)
        {
            //swimmingEvents.AddOrUpdate();
        }


        public void EnterSwimmersTime(Registrant aSwimmer, string time)
        {

        }

        public void Seed(byte maxLanes)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }


        class RegistrantsSwims
        {
            private List<Registrant> swimmers;
            private List<Swim> swims;

            public Swim Swim { get; set; }

            public void AddOrUpdate(Registrant swimmer, Swim swim)
            {


            }

            public bool Contains(Registrant swimmer)
            {
                return false;

            }

            private Swim GetSwimmersSwim(Registrant swimmer)
            {
                return new Swim();

            }

        }


    }
}
