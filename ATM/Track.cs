using System;

namespace ATM
{
    public class Track : ITrack
    {
        private string _tag;
        //private int _xcoord;
        //private int _ycoord;
        //private int _altitude;
        //private DateTime _timeStamp;

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


        public void updateTrack(ITrack track)
        {
            // TODO: Heading/Course (FAILED AT MATH!!!)
            {
                //var xDiff = Math.Sqrt(Math.Pow(track.XCoord - this.XCoord, 2));
                //var yDiff = Math.Sqrt(Math.Pow(track.YCoord - this.YCoord, 2));
                //var heading = Math.Atan2(yDiff, xDiff) * 180 / Math.PI;


                //// TESTING:

                //var xD_1 = 72070 - 72041;
                //var yD_1 = 5020 - 5000;
                //var heading_1 = Math.Atan2(yD_1, xD_1) * 180 / Math.PI;
                //heading_1 = heading_1 - 90;

                //var x1 = 72041;
                //var x2 = 72070;
                //var y1 = 5000;
                //var y2 = 5020;

                //var dot = x1 * x2 + y1 * y2;
                //var det = x1 * y2 - y1 * x2;

                //var angle = Math.Atan2(det, dot);
                //angle = angle * 180 / Math.PI;

                //var xD_2 = 72070 - 72041;
                //var yD_2 = 4980 - 5000;
                //var heading_2 = Math.Atan2(yD_2, xD_2) * 360 / Math.PI * 2;
                

                //var xD_3 = 72010 - 72041;
                //var yD_3 = 5020 - 5000;
                //var heading_3 = Math.Atan2(yD_3, xD_3) * 360 / Math.PI * 2;

                //var xD_4 = 72010 - 72041;
                //var yD_4 = 4980 - 5000;
                //var heading_4 = Math.Atan2(yD_4, xD_4) * 360 / Math.PI * 2;

            }

            // TODO: Speed/Velocity (m/s)

        }
    }
}