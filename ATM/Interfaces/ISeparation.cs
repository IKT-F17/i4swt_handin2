﻿using System;

namespace ATM
{
    public interface ISeparation
    {
        DateTime SeparationEventTimestamp { get; }
        string PlaneTag1 { get; }
        string PlaneTag2 { get; }


    }

    
}