using System;

namespace ATM
{
    public class Separation 
    {
        public Separation(string planeTag1, string planeTag2, DateTime separationEventTimestamp)
        {
            PlaneTag1 = planeTag1;
            PlaneTag2 = planeTag2;
            

        }
        public DateTime SeparationEventTimestampStart{get; private set; }
        public DateTime SeparationEventTimestampStop { get; private set; }
        public string PlaneTag1 { get; private set; }
        
        public string PlaneTag2 { get; private set; }



        

    }
}
