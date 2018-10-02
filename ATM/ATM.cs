using System.Collections.Generic;
using TransponderReceiver;

namespace ATM
{
    public class ATM
    {
        private ITransponderReceiver _receiver;
        private ITrackFactory _trackFactory;
        private ITrack _track;
        private List<ITrack> _tracks;
        //private IAirSpace _airSpace;
        //private List<ISeperation> _seperations;
        //private ILog _log;

        public ATM(ITransponderReceiver receiver, ITrackFactory trackFactory, ITrack track, List<ITrack> tracks)
        {
            _receiver = receiver;
            _trackFactory = trackFactory;
            _track = track;
            _tracks = tracks;

            _receiver.TransponderDataReady += OnTrackData;
        }

        private void OnTrackData(object sender, RawTransponderDataEventArgs e)
        {
            foreach (var rawData in e.TransponderData)
            {
                _track = _trackFactory.SpawnTrack(rawData);
            }

        }
    }
}
