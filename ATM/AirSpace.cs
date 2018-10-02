using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public class AirSpace : ITrack
    {


        private string _airSpaceID;
        private int _upperRightXCoord;
        private int _upperRightYCoord;
        private int _lowerLeftXCoord;
        private int _lowerLeftYCoord;
        private int _upperAltitude;
        private int _lowerAltitude;
        private int _horisontalSafetyDistance;
        private int _vertivalSafetyDistance;

        //  Defines the airspace
        public AirSpace(string airSpaceID, int upperRightXCoord, int upperRightYCoord, int lowerLeftXCoord, int lowerLeftYCoord, int upperAltitude, int lowerAltitude)
        {       //  Sets AirSpace boundarys
            _airSpaceID = airSpaceID;
            _upperRightXCoord = upperRightXCoord;
            _upperRightYCoord = upperRightYCoord;
            _lowerLeftXCoord = lowerLeftXCoord;
            _lowerLeftYCoord = lowerLeftYCoord;
            _upperAltitude = upperAltitude;
            _lowerAltitude = lowerAltitude;
            _horisontalSafetyDistance = 5000;
            _vertivalSafetyDistance = 300;
        }

        //  we want a list of airplanes so that we can find those that are within our boundaries.
        public List<ITrack> AirplaneList(List<ITrack> tracks)
        {
            //  First we populate the list with all available airplanes. 
            List<ITrack> AirplaneInterestsList = tracks;

            //  Then we sort those away that are outside our airspace boundaries 
            AirplaneInterestsList.RemoveAll(tracks => tracks.XCoord < _lowerLeftXCoord || tracks.XCoord > _upperRightYCoord);
            AirplaneInterestsList.RemoveAll(tracks => tracks.XCoord < _lowerLeftYCoord || tracks.YCoord > _upperRightYCoord);
            //  As well as airplanes that are below or above the height thresholds. 
            AirplaneInterestsList.RemoveAll(tracks => tracks.Altitude < _lowerAltitude || tracks.Altitude > _upperAltitude);

            return AirplaneInterestsList;
        }



        public bool IsTrackSafetyZoneClear(ITrack track1, ITrack track2)
        {

        }


    }
}