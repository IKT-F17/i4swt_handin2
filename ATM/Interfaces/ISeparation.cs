using System;

namespace ATM
{
    public interface ISeparation
    {
        DateTime SeparationEventTimestampStart { get; }
        DateTime SeparationEventTimestampStop { get; }

        string PlaneTag1 { get; }
        string PlaneTag2 { get; }


    }

    
}