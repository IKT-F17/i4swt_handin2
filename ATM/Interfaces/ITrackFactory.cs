using System;

namespace ATM
{
    public interface ITrackFactory
    {
        ITrack SpawnTrack(string rawTrackData);
    }



    
}
