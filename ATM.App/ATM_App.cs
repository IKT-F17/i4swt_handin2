using System;
using System.Collections.Generic;
using TransponderReceiver;

namespace ATM.App
{
    class ATM_App
    {
        static void Main(string[] args)
        {
            ITransponderReceiver receiver = TransponderReceiverFactory.CreateTransponderDataReceiver();
            ITrackFactory trackFactory = new TrackFactory();
            List<ITrack> tracks = new List<ITrack>();

            ATM controller = new ATM(receiver, trackFactory, tracks);

            Console.ReadKey();
        }
    }
}
