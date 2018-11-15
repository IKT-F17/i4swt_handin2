using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public class Telemetrics : ITelemetrics
    {

        //public static double CalculateHeading()
        //{
        //    TrackFactory track = new TrackFactory();
        //    track.OnNewTrackDataReadyEvent += Track_OnNewTrackDataReadyEvent;

        //    var DeltaX = track.XCoord - this.XCoord;
        //    var DeltaY = track.YCoord - this.YCoord;

        //    var heading = (90.0d - Math.Atan2(yDiff, xDiff) * 180 / Math.PI) ?;

        //    if (heading < 0.0d) heading += 360.0;


        //    return heading;
        //}

        //private static void Track_OnNewTrackDataReadyEvent(object sender, Track e)
        //{
        //    var DeltaX = e.XCoord - this.XCoord;
        //    throw new NotImplementedException();
        //}

    }
}
