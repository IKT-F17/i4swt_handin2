using System;
using System.Collections.Generic;
using System.Globalization;
using ATM.Interfaces;

namespace ATM
{
    public class TrackFactory : ITrackFactory
    {
        public event EventHandler<ITrack> OnNewTrackDataReadyEvent;

        public ITrack SpawnTrack(string rawTrackData)
        {
            string[] rawDataSplit = rawTrackData.Split(';');
            string Tag = rawDataSplit[0];
            int XCoord = Convert.ToInt32(rawDataSplit[1]);
            int YCoord = Convert.ToInt32(rawDataSplit[2]);
            int Altitude = Convert.ToInt32(rawDataSplit[3]);
            DateTime TimeStamp =
            DateTime.ParseExact(rawDataSplit[4], "yyyyMMddHHmmssfff", CultureInfo.InvariantCulture);

            //return new Track(Tag, XCoord, YCoord, Altitude, TimeStamp);

            var track = new Track(Tag, XCoord, YCoord, Altitude, TimeStamp);

            OnNewTrackDataReadyEvent?.Invoke(this, track);

            return null;
        }






    }


}