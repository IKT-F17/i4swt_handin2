using System.Collections.Generic;
using TransponderReceiver;

namespace ATM
{
    public class ATM
    {
        private ITrack _track;
        private ITrackFactory _trackFactory;
        private ITransponderReceiver _receiver;
        //private List<ITrack> _tracks;
        public List<ITrack> Global_TrackData;
        //private IAirSpace _airSpace;
        //private List<ISeperation> _seperations;
        //private ILog _log;

        public ATM(ITransponderReceiver receiver, ITrackFactory trackFactory, List<ITrack> tracks)
        {
            _receiver = receiver;
            _trackFactory = trackFactory;
            Global_TrackData = tracks;

            _receiver.TransponderDataReady += OnTrackData;
        }

        private void OnTrackData(object sender, RawTransponderDataEventArgs e)
        {
            var rawTrackData = e.TransponderData;

            foreach (var item in rawTrackData)
            {
                _track = _trackFactory.SpawnTrack(item);

                Global_TrackData.Add(_track);
            }
        }
    }
}
