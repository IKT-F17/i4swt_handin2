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

        public int XCoord
        {
            get => _xcoord;
            set => throw new NotImplementedException();
        }

        public int YCoord
        {
            get => _ycoord;
            set => throw new NotImplementedException();
        }

        public int Altitude
        {
            get => _altitude;
            set => throw new NotImplementedException();
        }

        public DateTime TimeStamp
        {
            get => _timeStamp;
            set => throw new NotImplementedException();
        }
    }
}