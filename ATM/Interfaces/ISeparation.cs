using System;

namespace ATM.Interfaces
{
    public interface ISeparation
    {
        private DateTime SeparationEventTimestamp { get; }
        private string PlaneTag1 { get; }
        private string PlaneTag2 { get; }


    }

    
}