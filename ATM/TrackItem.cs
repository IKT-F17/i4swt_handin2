using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class TrackItem
    {
        private string Tag { get; set; }
        private Point Position { get; set; }
        private DateTime TimeStamp { get; set; }
        private double Heading { get; set; }
        private double Speed { get; set; }
        private Dictionary<DateTime, Point> TrackingData { get; set; }

        static void UpdateLocation(TrackItem)
        {
            // TODO - Skal sætte Heading og Speed udfra medsendte TrackItem ift. eget ("Gammel") Position og TimeStamp
            // Herefter skal den opdatere Position og TimeStamp til det medsendte TrackItem og Add det medsendte
            // Trackitem til TrackindData Dictionary.
        }



    }
}
