using System;
using System.Collections.Generic;
using System.Globalization;
using ATM.Interfaces;

namespace ATM
{
    
    public class TrackFactory : ITrackFactory, ISubject
    {
        public List<ITrack> _observers;

        void registerObserver(ITrack observers)
        {
            _observers.Add(observers);
        }

        void removeObserver(ITrack observers)
        {
            _observers.Remove(observers);
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

            Console.WriteLine("Receiving data from TrackFactory...");
            Console.WriteLine($"Current Tag: {tag}");
            Console.WriteLine($"Current X-Coord.: {xcoord}");
            Console.WriteLine($"Current Y-Coord.: {ycoord}");
            Console.WriteLine($"Current Altitude: {altitude}");
            Console.WriteLine($"Current Time Stamp: {timeStamp}");

            return new Track(tag, xcoord, ycoord, altitude, timeStamp);
        }
    }
}
