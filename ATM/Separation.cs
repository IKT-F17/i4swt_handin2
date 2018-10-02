using System;

namespace ATM
{
    public class Separation 
    {
        public Separation(ITrack track1, ITrack track3)
        {
            

        }
        public DateTime SeparationEventTimestampStart
        { get; private set; }
        public DateTime SeparationEventTimestampStop { get; private set; }
        public string PlaneTag1 { get; private set; }
        
        public string PlaneTag2 { get; private set; }



        

    }
}
