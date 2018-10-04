using System;
using System.Collections.Generic;
using System.Globalization;
using ATM.Interfaces;

namespace ATM
{
    
    public class TrackFactory : ITrackFactory, ISubject
    {
        public List<ITrack> _observers;

        void registerObserver(ITrack observer)
        {
            _observers.Add(observer);
        }

        void removeObserver(ITrack observer)
        {
            int i = _observers.IndexOf(observer);
            if (i >= 0)
            {
                _observers.Remove(observer);
            }

            //Freds
            // _observers.Remove(observers);
        }

        void notifyObservers(ITrack observer)
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }

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