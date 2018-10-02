using System;

namespace ATM.Interfaces
{
    public interface ISeparation
    {
        DateTime SeparationEventTimestamp { get; }
        string PlaneTag1 { get; }
        string PlaneTag2 { get; }


    }

    
}