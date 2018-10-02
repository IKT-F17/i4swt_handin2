using System;

namespace ATM.Interfaces
{
    public class Track : ITrack
    {
        private string _tag;
        private int _xcoord;
        private int _ycoord;
        private int _altitude;
        private DateTime _timeStamp;

        public Track(string tag, int xcoord, int ycoord, int altitude, DateTime timeStamp)
        {
            Tag = tag;
            XCoord = xcoord;
            YCoord = ycoord;
            Altitude = altitude;
            TimeStamp = timeStamp;
        }

        public string Tag
        {
            get => _tag;
            set
            {
                if (value.Length != 6)
                    return;

                _tag = value;
            }
        }

        public int XCoord { get; set; }

        public int YCoord { get; set; }

        public int Altitude { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}