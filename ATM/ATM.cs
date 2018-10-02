using System;
using System.Collections.Generic;
using ATM.Interfaces;
using TransponderReceiver;

namespace ATM
{
    public class ATM
    {
        private ITrack _track;
        private List<ITrack> tracks;
        private ITransponderReceiver _receiver;
        private ITrackFactory _trackFactory;

        public ATM()
        {

        }
    }
}
