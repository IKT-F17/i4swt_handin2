//using System;
//using System.Collections.Generic;

//namespace ATM
//{
//    public class AirSpace : ITrack
//    {


        

//        //  Defines the airspace
//        public AirSpace(string airSpaceID, int upperRightXCoord, int upperRightYCoord, int lowerLeftXCoord, int lowerLeftYCoord, int upperAltitude, int lowerAltitude)
//        {       //  Sets AirSpace boundarys
//            //_airSpaceID = airSpaceID;
//            //_upperRightXCoord = upperRightXCoord;
//            //_upperRightYCoord = upperRightYCoord;
//            //_lowerLeftXCoord = lowerLeftXCoord;
//            //_lowerLeftYCoord = lowerLeftYCoord;
//            //_upperAltitude = upperAltitude;
//            //_lowerAltitude = lowerAltitude;
//            //_horisontalSafetyDistance = 5000;
//            //_vertivalSafetyDistance = 300;
//        }

//        private string _airSpaceID { get; set; }
//        private int _upperRightXCoord { get; set; }
//        private int _upperRightYCoord { get; set; }
//        private int _lowerLeftXCoord { get; set; }
//        private int _lowerLeftYCoord { get; set; }
//        private int _upperAltitude { get; set; }
//        private int _lowerAltitude { get; set; }
//        private int _horisontalSafetyDistance { get; set; }
//        private int _vertivalSafetyDistance { get; set; } 


//        //  we want a list of airplanes so that we can find those that are within our boundaries.
//        public List<ITrack> AirplaneList(List<ITrack> tracks)
//        {
//            //  First we populate the list with all available airplanes. 
//            List<ITrack> AirplaneInterestsList = tracks;

//            //  Then we sort those away that are outside our airspace boundaries 
//            AirplaneInterestsList.RemoveAll(track => track.XCoord < _lowerLeftXCoord || track.XCoord > _upperRightXCoord);
//            AirplaneInterestsList.RemoveAll(track => track.XCoord < _lowerLeftYCoord || track.YCoord > _upperRightYCoord);
//            //  As well as airplanes that are below or above the height thresholds. 
//            AirplaneInterestsList.RemoveAll(track => track.Altitude < _lowerAltitude || track.Altitude > _upperAltitude);

//            return AirplaneInterestsList;
//        }



//        public bool IsTrackSafetyZoneClear(ITrack track1, ITrack track2)
//        {
//            int horisontalSsafetyZone = (int)(Math.Sqrt (Math.Pow ((track1.XCoord - track2.XCoord), 2)) + Math.Pow ((track1.YCoord - track2.YCoord), 2));
//            int verticalSsafetyZone = (int)(Math.Sqrt(Math.Pow((track1.Altitude - track2.Altitude), 2)));

//            return (horisontalSsafetyZone < _horisontalSafetyDistance && verticalSsafetyZone < _vertivalSafetyDistance);
//        }


//    }
//}