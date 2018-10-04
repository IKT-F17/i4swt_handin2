using System;
using System.Globalization;

namespace ATM
{
    public class TrackFactory : ITrackFactory
    {
        public ITrack SpawnTrack(string rawTrackData)
        {
            string[] rawDataSplit = rawTrackData.Split(';');
            string tag = rawDataSplit[0];
            int xcoord = Convert.ToInt32(rawDataSplit[1]);
            int ycoord = Convert.ToInt32(rawDataSplit[2]);
            int altitude = Convert.ToInt32(rawDataSplit[3]);
            DateTime timeStamp =
                DateTime.ParseExact(rawDataSplit[4], "yyyyMMddHHmmssfff", CultureInfo.InvariantCulture);

            return new Track(tag, xcoord, ycoord, altitude, timeStamp);
        }
    }
}