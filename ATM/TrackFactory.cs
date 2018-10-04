using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ATM.Interfaces;




namespace ATM
{

    
    
    public class TrackFactory : TrackItem , ITrackFactory 
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

            Console.WriteLine("Receiving data from TrackFactory...");
            Console.WriteLine($"Current Tag: {tag}");
            Console.WriteLine($"Current X-Coord.: {xcoord}");
            Console.WriteLine($"Current Y-Coord.: {ycoord}");
            Console.WriteLine($"Current Altitude: {altitude}");
            Console.WriteLine($"Current Time Stamp: {timeStamp}");


            return new Track(tag, xcoord, ycoord, altitude, timeStamp);

            

        }

        public Dictionary<string, TrackItem> LastPosition;

        public TrackItem UpdateTrackList(Track)
        {

            foreach (var TrackItem in CurrentView )
            {
                if (!LastPosition.ContainsKey(TrackItem.Tag))
                {
                    LastPosition.Add(TrackItem.Tag, TrackItem);
                }
                else
                    LastPosition[TrackItem.Tag].UpdateLocation(TrackItem);
            }

            var DeletedTags = LastPosition.Keys.Where(x => CurrentView.Keys.contains(x)).ToList();

            foreach (var DeletedTag in DeletedTags)
            {
                LastPosition.Remove(DeletedTag);
            }

        }


    }
}
