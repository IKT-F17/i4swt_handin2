using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using ATM.Interfaces;

namespace ATM
{
    public class Track : ITrack, IObserver
    {

        #region Concrete OBSERVER
        void IObserver.Update()
        {
            //Do Something
        }
        #endregion

        #region Concrete SUBJECT 

        

        private List<IObserver> _observers = new List<IObserver>();
 
        public void registerObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            int i = _observers.IndexOf(observer);
            if (i >= 0)
            {
                _observers.Remove(i);
            }

            
        }
        public void notifyObservers(IObserver observer)
        {
            foreach (var i in _observers)
            {
                
            }
            
        }

        #endregion


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